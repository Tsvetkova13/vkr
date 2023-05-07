using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CardioExpert4._0
{
    public partial class FormMain : Form
    {
        private Core core;
        public FormMain()
        {
            InitializeComponent();
            core = new Core();
            core.RTF = rtf;
        }
                
        private void tsmiData_Click(object sender, EventArgs e)  // открыть данные ЭКГ
        {
            // выбираем файл
            Open.FileName = "Data EKG.txt";                    // имя файла по умолчанию
            Open.Filter = "Файлы ЭКГ|*.txt|Все файлы|*.*";     // фильтр
            if (Open.ShowDialog() != DialogResult.OK) return;

            tabControl.SelectedIndex = 0;                      // открываем вкладку ЭКГ

            StreamReader fData = new StreamReader(Open.FileName);  
            
            DataSet ds = new DataSet();
            ds.Tables.Add("TabData");

            String line = fData.ReadLine(); 
            string[] rvalue = System.Text.RegularExpressions.Regex.Split(line, "\t");
            for(int r = 0; r < rvalue.Length; r++)
            {
                ds.Tables[0].Columns.Add(rvalue[r]);
            }
            string subline = fData.ReadLine();
            while (subline != null)
            {
                string[] svalue = System.Text.RegularExpressions.Regex.Split(subline, "\t");
                ds.Tables[0].Rows.Add(svalue);
                subline = fData.ReadLine();
            }
            dgvData.DataSource = ds.Tables[0];
            fData.Close();
            tsNameFile.Text = Open.FileName;    // вывод имени файла в статус-строку
        }


        private void tsmiRules_Click(object sender, EventArgs e)  // Открыть список правил
        {
            // выбираем файл
            Open.FileName = "Rules.txt";                       // имя файла по умолчанию
            Open.Filter = "Файлы правил|*.txt|Все файлы|*.*";   // фильтр
            if (Open.ShowDialog() != DialogResult.OK) return;          
              
            tabControl.SelectedIndex = 1;                       // открываем вкладку правил

            // открываем файл
            StreamReader fRules = new StreamReader(Open.FileName, Encoding.GetEncoding(1251));
            DataSet ds = new DataSet();
            ds.Tables.Add("TabRules");

            String line = fRules.ReadLine();
            string[] rvalue = System.Text.RegularExpressions.Regex.Split(line, "\t");
            for (int r = 0; r < rvalue.Length; r++)
            {
                ds.Tables[0].Columns.Add(rvalue[r]);
            }


            string subline = fRules.ReadLine();
            while (subline != null)
            {
                string[] svalue = System.Text.RegularExpressions.Regex.Split(subline, "\t");
                ds.Tables[0].Rows.Add(svalue);
                subline = fRules.ReadLine();
            }
                                               
            dgvRules.DataSource = ds.Tables[0];
            fRules.Close();
            tsNameFile.Text = Open.FileName;  // вывод имени файла в статус-строку
        }

        struct Fact
        {
            public string peaks;//Имя зубца
            public double valueS;//величина амплитуды
            public double valueMM;//ширина 
        }
        Fact[] Facts = new Fact[1000];//факты из данных ЭКГ

        public void DataToMassive()
        {
            for (int i = 0; i < dgvData.RowCount-1; i++)
            {
                Facts[i].peaks = dgvData.Rows[i].Cells[0].Value.ToString();
                Facts[i].valueS = Convert.ToDouble(dgvData.Rows[i].Cells[1].Value);
                Facts[i].valueMM = Convert.ToDouble(dgvData.Rows[i].Cells[2].Value);
            }
        }

        public void AddFacts()  // 
        {
            core.ClearFacts();  // удаление предыдущих фактов
            DataToMassive();
            string sf;
            for(int i = 0; i < dgvData.RowCount; i++)
            {
                if ((Facts[i].peaks == "P1") && (Facts[i].valueS > 0.1))
                {
                    sf = "P1>0.1s";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "P2") && (Facts[i].valueS > 0.1))
                {
                    sf = "P2>0.1s";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "PavL") && (Facts[i].valueS > 0.1))
                {
                    sf = "PavL>0.1s";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "PV5") && (Facts[i].valueS > 0.1))
                {
                    sf = "PV5>0.1s";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "PV6") && (Facts[i].valueS > 0.1))
                {
                    sf = "PV6>0.1s";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "P2") && (Facts[i].valueMM > 2.5))
                {
                    sf = "P2>2.5mm";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "P3") && (Facts[i].valueMM > 2.5))
                {
                    sf = "P3>2.5mm";
                    core.AddFact(sf);
                }
                if ((Facts[i].peaks == "PavF") && (Facts[i].valueMM > 2.5))
                {
                    sf = "PavF>2.5mm";
                    core.AddFact(sf);
                }
            }
            
        }


        public void RulesToMassive()  // Перегрузка правил из грида
        {
            core.ClearRules();  // сброс предыдущих правил
            for (int i = 0; i < dgvRules.RowCount; i++)
            {
                string RulePart1 = dgvRules.Rows[i].Cells[0].Value.ToString();
                string RulePart2 = dgvRules.Rows[i].Cells[1].Value.ToString();
                core.AddRules(RulePart1, RulePart2);
            }
        }

        public void InputMainGoal()  // Определение главной цели
        {            
            string s = mainGoal.Text;
            core.InputGoal(s);
        }

        private void btPlay_Click(object sender, EventArgs e)  // Диагностика
        {
            tabControl.SelectedIndex = 2;  // открываем вкладку Протокол
            rtf.Clear();                   // чистим протокол
            core.Clear();                  // очистка ядра экспертной системы            
            AddFacts();                    // переложить данные ЭКГ из грида в массив рабочей памяти, преобразовав в факты AddFacts();
            RulesToMassive();              // перегрузка правил из грида в массив правил         
            InputMainGoal();               // определение главной цели           
            core.BackFind();               // запуск обратного поиска
            if (!core.ConfirmGoal())
            {   // если цель не достигнута, то сообщение:"диагноз не подтверждён"
                rtf.AppendText("\n< < < < < < < < [ Диагноз не подтвержден! ] > > > > > > > >\n");
                //MessageBox.Show("Диагноз не подтвержден!", "", MessageBoxButtons.OK);                
            }
            else
            {   // если цель достигнута, то формируем протокол
                rtf.AppendText("\n< < < < < < < < [ Диагноз подтвержден! ] > > > > > > > >\n");                
                core.Find();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите покинуть КардиоЭксперт?", "", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скачать руководство пользователя?", "", MessageBoxButtons.YesNo);
        }

        private void tsmiProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CardioExpert v.4.1\n \n ФГБОУ ВО ИГЭУ им.В.И.Ленина\n Кафедра программного обеспечения компьютерных систем\n Разработчик: студ. гр 4-46 Д.В.Цветкова\n Контакты: тел.+79109804907, e-mail dchvet09@gmail.com      ", "", MessageBoxButtons.OK);
        }

        private void tsmiFind_Click(object sender, EventArgs e)  // Прямой вывод
        {
            core.Find();            
        }

        private void tsmiBackfind_Click(object sender, EventArgs e)  // Обратный вывод
        {
            core.BackFind();            
        }

        private void tsmiSave_Click(object sender, EventArgs e)  // Сохранение протокола
        {
            Save.FileName = "Report.rtf";                        // имя файла по умолчанию
            Save.Filter = "Файлы отчетов|*.rtf|Все файлы|*.*";   // фильтр
            if (Save.ShowDialog() != DialogResult.OK) return;    // диалог выбора файла
            rtf.SaveFile(Save.FileName);                         // сохраняем файл
        }
    }
}
