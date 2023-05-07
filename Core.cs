using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardioExpert4._0
{
    public class Core
    {

        struct Rule //правило
        {
            public string part1;  // условная часть
            public string part2;  // диагностическая часть
            public bool use;      // флаг использования этого правила
        }
        Rule[] Rules = new Rule[100];       // база правил


        const string chAnd = ";";           // разделитель "И"
        
        String[] WorkMem = new string[100]; // рабочая память
        String[] Goals = new string[100];   // цели для обратного вывода
        

        public RichTextBox RTF = null;      // протокол

        public int nf = 0;
        public int nr = 0;
        public int ng = 0;
        //public bool confirm;

        public void ClearFacts()  // Очистка массива фактов
        {
            nf = 0;
        }
        public void ClearRules()  // Очистка массива правил
        {            
            nr = 0;            
        }
        public void ClearGoals()  // Очистка массива целей
        {
            ng = 0;
        }

        public void Clear()  // Очистка массивов
        {          
            ClearFacts();  // очистка массива фактов
            ClearRules();  // очистка массива правил
            ClearGoals();  // очистка массива целей         
        }

        public string MyTrim(string s)  // Обрезка пробелов в начале и конце
        {
            return s.Trim(new Char[] { ' ', '"','.','\t' });           
        }


        string GetFact(ref string s)  // Выделение факта из списка
        {
            string v;                    // выделенный факт
            int j = s.IndexOf(chAnd);
            if (j < 0)
            {
                v = s; s = "";
            }
            else
            {
                v = s.Substring(0, j);
                s = s.Remove(0, j + 1);
            }
            return v.Trim();
        }

        /*
        public string GetFact(string s)  // выделение одного факта из списка (удаление разделителя И)
        {
            string v="";                 // выделенный факт
            bool j = s.Contains(chAnd);  // поиск разделителя И
            if (j)  // нашёлся разделитель И
            {
                int index = s.IndexOf(chAnd);   // позиция разделителя И в строке
                v = s.Remove(index);         // удаление разделителя И
            }
            else   // не нашёлся разделитель И
            {
                v = s;                          
                s = "";                         
            }
            return v;
        }
        */

        public bool IsFact(string s)  // Проверка наличия факта в рабочей памяти
        {
            s = MyTrim(s);               // выделили факт из строчки
            bool res = false;            // флаг наличия факта в рабочей памяти
            for(int i = 0; i < nf; i++)  // Пробегаем по общему количеству фактов
            {
                if (WorkMem[i] == s) res = true;  // Если в памяти есть такой факт, то выставляем флаг в тру
            }
            return res;  // возвращаем флаг
        }

        public bool IsTrue(string s)  // Проверка истинности выражения
        {
            bool res = false;    // результат
            bool first = true;   // флаг первого факта
            s = MyTrim(s);
            while (s != "")
            {
                string v=GetFact(ref s);  // выделили факт из текущей строки
                bool tres = IsFact(v);    // проверили наличие этого факта в рабочей памяти
                if (first)                // накопление результата
                {
                    res = tres; first = false;
                }
                else res = res && tres;
            }
            return res;
        }

       
        public void AddFact(string sf)  // добавление факта
        {
            sf = MyTrim(sf);
            if (!IsFact(sf))
            {
                WorkMem[nf] = sf;
                RTF.AppendText("Новый факт: " + WorkMem[nf] + "\n");   // отображение нового факта в логе
                nf++;                
            }
        }

        public void AddRules(string sr1, string sr2)
        {
            Rules[nr].part1 = MyTrim(sr1);
            Rules[nr].part2 = MyTrim(sr2);
            Rules[nr].use = true;
            RTF.AppendText("Правило: ЕСЛИ " + Rules[nr].part1 + " ТО " + Rules[nr].part2 + "\n");
            nr++;
        }

        public bool TestRule(int r)  // Проверка исполнения правила номер r
        {
            bool res = false;  // флаг срабатывания правила
            
            if (Rules[r].use && IsTrue(Rules[r].part1))
            {
                AddFact(Rules[r].part2);
                Rules[r].use = false;
                res = true;
            }
            return res;
        }

        public bool IsGoal(string s)  // Проверка наличия цели s //ДИАГНОЗ Димы
        {
            s = MyTrim(s);
            bool res = false;   // результат
            for (int i = 0; i < ng; i++)
            {
                if (Goals[i] == s) res = true;
                //RTF.AppendText(Goals[i] + "\n");
            }
                
            return res;
        }

        public void AddGoal(string s)  // Добавление цели
        {
            s = MyTrim(s);
            if ((s != "") && (!IsGoal(s)))
            {
                Goals[ng] = s;
                RTF.AppendText("Новая цель: " + Goals[ng] + "\n");  // вывод цели в лог
                ng++;
            }
            
        }

        public void InputGoal(string s)  // принимает главную цель
        {
            ClearGoals();
            AddGoal(s);
        }
                

        public bool ConfirmGoal()  // подтверждение цели
        {
            bool confirm = false;  // флаг подтверждения сделат глобальной
            if (ng>0 && Goals[0] != "")
            {
                if (IsTrue(Goals[0])) confirm = true;  // цель подтверждена
                else confirm = false;                  // цель не подтверждена
            }
            return confirm;
        }

        public void Find()  // механизм прямого логического вывода
        {
            RTF.AppendText("\n======== Прямой логический вывод ========\n");
            bool fNext;   // флаг продолжения поиска
            //InputGoal();  // ввод цели
            do
            {
                fNext = false;
                for (int r = 0; r < nr; r++)
                {
                    if (TestRule(r))
                    {
                        fNext = true;
                        RTF.AppendText("Сработало правило: ЕСЛИ " + Rules[r].part1 + " ТО " + Rules[r].part2 + "\n");
                    }
                    else fNext = false;
                }
            } while (fNext);
            ConfirmGoal();  // подтверждение цели            
        }

        public void BackFind()  // Механизм обратного логического вывода
        {            
            RTF.AppendText("\n======== Обратный логический вывод ========\n");
            bool fNext;   // флаг продолжения поиска
            //InputGoal();  // ввод цели
            do
            {
                fNext = false;
                for(int g = 0; g < ng; g++)
                {
                    for(int r = 0; r < nr; r++)
                    {
                        if(Rules[r].use && (Rules[r].part2 == Goals[g]))
                        {                           
                            AddGoal(Rules[r].part1);        // формирование новых целей                            
                            if (TestRule(r)) fNext = true;  // проверка наличия новых фактов
                            RTF.AppendText("Сработало правило: ЕСЛИ " + Rules[r].part1 + " ТО " + Rules[r].part2 + "\n");
                            //RTF.AppendText("ЕСЛИ "+Rules[r].part1+" ТО "+Rules[r].part2);
                        }
                    }
                }

            } while (fNext);
            ConfirmGoal();    // подтверждение цели
        }
    }
}