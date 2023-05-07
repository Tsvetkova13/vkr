namespace CardioExpert4._0
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRules = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiagnostic = new System.Windows.Forms.ToolStripMenuItem();
            this.mRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackfind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.btPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsNameFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageECG = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.tabPageDiag = new System.Windows.Forms.TabPage();
            this.rtf = new System.Windows.Forms.RichTextBox();
            this.ToolDiag = new System.Windows.Forms.ToolStrip();
            this.mainGoal = new System.Windows.Forms.ToolStripTextBox();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.Status.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageECG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabPageRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.tabPageDiag.SuspendLayout();
            this.ToolDiag.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiDiagnostic,
            this.tsmiHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(923, 28);
            this.MainMenu.TabIndex = 0;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(59, 24);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiData,
            this.tsmiRules});
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(236, 26);
            this.tsmiOpen.Text = "Открыть";
            // 
            // tsmiData
            // 
            this.tsmiData.Name = "tsmiData";
            this.tsmiData.Size = new System.Drawing.Size(197, 26);
            this.tsmiData.Text = "Данные ЭКГ";
            this.tsmiData.Click += new System.EventHandler(this.tsmiData_Click);
            // 
            // tsmiRules
            // 
            this.tsmiRules.Name = "tsmiRules";
            this.tsmiRules.Size = new System.Drawing.Size(197, 26);
            this.tsmiRules.Text = "Список правил";
            this.tsmiRules.Click += new System.EventHandler(this.tsmiRules_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::CardioExpert4._0.Properties.Resources.save__1_;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(236, 26);
            this.tsmiSave.Text = "Сохранить протокол";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(236, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiDiagnostic
            // 
            this.tsmiDiagnostic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRun,
            this.toolStripSeparator1,
            this.tsmiFind,
            this.tsmiBackfind});
            this.tsmiDiagnostic.Name = "tsmiDiagnostic";
            this.tsmiDiagnostic.Size = new System.Drawing.Size(111, 24);
            this.tsmiDiagnostic.Text = "Диагностика";
            // 
            // mRun
            // 
            this.mRun.Image = global::CardioExpert4._0.Properties.Resources.play;
            this.mRun.Name = "mRun";
            this.mRun.Size = new System.Drawing.Size(212, 26);
            this.mRun.Text = "Пуск";
            this.mRun.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // tsmiFind
            // 
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.Size = new System.Drawing.Size(212, 26);
            this.tsmiFind.Text = "Прямой вывод";
            this.tsmiFind.Click += new System.EventHandler(this.tsmiFind_Click);
            // 
            // tsmiBackfind
            // 
            this.tsmiBackfind.Name = "tsmiBackfind";
            this.tsmiBackfind.Size = new System.Drawing.Size(212, 26);
            this.tsmiBackfind.Text = "Обратный вывод";
            this.tsmiBackfind.Click += new System.EventHandler(this.tsmiBackfind_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.tsmiProgram});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(81, 24);
            this.tsmiHelp.Text = "Справка";
            // 
            // tsmiUser
            // 
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(278, 26);
            this.tsmiUser.Text = "Руководство пользователя";
            this.tsmiUser.Click += new System.EventHandler(this.tsmiUser_Click);
            // 
            // tsmiProgram
            // 
            this.tsmiProgram.Name = "tsmiProgram";
            this.tsmiProgram.Size = new System.Drawing.Size(278, 26);
            this.tsmiProgram.Text = "О программе";
            this.tsmiProgram.Click += new System.EventHandler(this.tsmiProgram_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPlay,
            this.toolStripLabel1,
            this.btSave,
            this.toolStripLabel2});
            this.ToolBar.Location = new System.Drawing.Point(0, 28);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(923, 27);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // btPlay
            // 
            this.btPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPlay.Image = global::CardioExpert4._0.Properties.Resources.play;
            this.btPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(29, 24);
            this.btPlay.Text = "Пуск";
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 24);
            this.toolStripLabel1.Text = " Пуск";
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = global::CardioExpert4._0.Properties.Resources.save__1_;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(29, 24);
            this.btSave.Text = "Сохранить протокол";
            this.btSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(153, 24);
            this.toolStripLabel2.Text = "Сохранить протокол";
            // 
            // Status
            // 
            this.Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsNameFile});
            this.Status.Location = new System.Drawing.Point(0, 442);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.Status.Size = new System.Drawing.Size(923, 26);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLabel1.Text = "Имя файла:";
            // 
            // tsNameFile
            // 
            this.tsNameFile.Name = "tsNameFile";
            this.tsNameFile.Size = new System.Drawing.Size(158, 20);
            this.tsNameFile.Text = "нет открытых файлов";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageECG);
            this.tabControl.Controls.Add(this.tabPageRules);
            this.tabControl.Controls.Add(this.tabPageDiag);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 55);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(923, 387);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageECG
            // 
            this.tabPageECG.Controls.Add(this.dgvData);
            this.tabPageECG.Location = new System.Drawing.Point(4, 25);
            this.tabPageECG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageECG.Name = "tabPageECG";
            this.tabPageECG.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageECG.Size = new System.Drawing.Size(915, 358);
            this.tabPageECG.TabIndex = 0;
            this.tabPageECG.Text = "Данные ЭКГ";
            this.tabPageECG.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvData.Location = new System.Drawing.Point(4, 4);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(907, 350);
            this.dgvData.TabIndex = 0;
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.dgvRules);
            this.tabPageRules.Location = new System.Drawing.Point(4, 25);
            this.tabPageRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRules.Size = new System.Drawing.Size(915, 351);
            this.tabPageRules.TabIndex = 1;
            this.tabPageRules.Text = "Список правил";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.AllowUserToDeleteRows = false;
            this.dgvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(4, 4);
            this.dgvRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.ReadOnly = true;
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.Size = new System.Drawing.Size(907, 343);
            this.dgvRules.TabIndex = 0;
            // 
            // tabPageDiag
            // 
            this.tabPageDiag.Controls.Add(this.rtf);
            this.tabPageDiag.Controls.Add(this.ToolDiag);
            this.tabPageDiag.Location = new System.Drawing.Point(4, 25);
            this.tabPageDiag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDiag.Name = "tabPageDiag";
            this.tabPageDiag.Size = new System.Drawing.Size(915, 351);
            this.tabPageDiag.TabIndex = 2;
            this.tabPageDiag.Text = "Протокол";
            this.tabPageDiag.UseVisualStyleBackColor = true;
            // 
            // rtf
            // 
            this.rtf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtf.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtf.Location = new System.Drawing.Point(0, 27);
            this.rtf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtf.Name = "rtf";
            this.rtf.Size = new System.Drawing.Size(915, 324);
            this.rtf.TabIndex = 2;
            this.rtf.Text = "";
            // 
            // ToolDiag
            // 
            this.ToolDiag.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolDiag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainGoal});
            this.ToolDiag.Location = new System.Drawing.Point(0, 0);
            this.ToolDiag.Name = "ToolDiag";
            this.ToolDiag.Size = new System.Drawing.Size(915, 27);
            this.ToolDiag.TabIndex = 1;
            this.ToolDiag.Text = "toolStrip2";
            // 
            // mainGoal
            // 
            this.mainGoal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainGoal.Name = "mainGoal";
            this.mainGoal.Size = new System.Drawing.Size(665, 27);
            this.mainGoal.Text = "гипертрофия левого предсердия, нарушение в предсердной проводимости";
            // 
            // Open
            // 
            this.Open.DefaultExt = "txt";
            this.Open.FileName = "Data EKG.txt";
            this.Open.Filter = "Файлы ЭКГ|*.txt|Все файлы|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 468);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "КардиоЭксперт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageECG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabPageRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.tabPageDiag.ResumeLayout(false);
            this.tabPageDiag.PerformLayout();
            this.ToolDiag.ResumeLayout(false);
            this.ToolDiag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiData;
        private System.Windows.Forms.ToolStripMenuItem tsmiRules;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiagnostic;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackfind;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiProgram;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton btPlay;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageECG;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.TabPage tabPageDiag;
        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.ToolStripStatusLabel tsNameFile;
        private System.Windows.Forms.ToolStrip ToolDiag;
        private System.Windows.Forms.ToolStripTextBox mainGoal;
        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.ToolStripMenuItem mRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rtf;
        private System.Windows.Forms.SaveFileDialog Save;
    }
}

