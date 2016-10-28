namespace BanksApp
{
    partial class BanksForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanksForm));
            this.btn_CorrBank = new System.Windows.Forms.Button();
            this.gb_MyValues = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_CorrBank = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dGV_TOP = new System.Windows.Forms.DataGridView();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Karma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.gb_TOP = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_BankList = new System.Windows.Forms.Button();
            this.gb_MyValues.SuspendLayout();
            this.gb_CorrBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TOP)).BeginInit();
            this.gb_TOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CorrBank
            // 
            this.btn_CorrBank.Location = new System.Drawing.Point(48, 295);
            this.btn_CorrBank.Name = "btn_CorrBank";
            this.btn_CorrBank.Size = new System.Drawing.Size(185, 41);
            this.btn_CorrBank.TabIndex = 0;
            this.btn_CorrBank.Text = "Найти банк";
            this.btn_CorrBank.UseVisualStyleBackColor = true;
            this.btn_CorrBank.Click += new System.EventHandler(this.btn_CorrBank_Click);
            // 
            // gb_MyValues
            // 
            this.gb_MyValues.Controls.Add(this.label8);
            this.gb_MyValues.Controls.Add(this.comboBox1);
            this.gb_MyValues.Controls.Add(this.textBox2);
            this.gb_MyValues.Controls.Add(this.textBox4);
            this.gb_MyValues.Controls.Add(this.textBox3);
            this.gb_MyValues.Controls.Add(this.textBox1);
            this.gb_MyValues.Controls.Add(this.label3);
            this.gb_MyValues.Controls.Add(this.label4);
            this.gb_MyValues.Controls.Add(this.label2);
            this.gb_MyValues.Controls.Add(this.label1);
            this.gb_MyValues.Location = new System.Drawing.Point(12, 12);
            this.gb_MyValues.Name = "gb_MyValues";
            this.gb_MyValues.Size = new System.Drawing.Size(427, 183);
            this.gb_MyValues.TabIndex = 1;
            this.gb_MyValues.TabStop = false;
            this.gb_MyValues.Text = "Мои условия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(15, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Нижняя граница доверия(надежности)";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(221, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 21);
            this.textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Срок погашения(мес)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сумма кредита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Мин на расходы(мес)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЗП в месяц";
            // 
            // gb_CorrBank
            // 
            this.gb_CorrBank.Controls.Add(this.label7);
            this.gb_CorrBank.Controls.Add(this.label6);
            this.gb_CorrBank.Controls.Add(this.label5);
            this.gb_CorrBank.Controls.Add(this.textBox7);
            this.gb_CorrBank.Controls.Add(this.textBox6);
            this.gb_CorrBank.Controls.Add(this.textBox5);
            this.gb_CorrBank.Location = new System.Drawing.Point(445, 12);
            this.gb_CorrBank.Name = "gb_CorrBank";
            this.gb_CorrBank.Size = new System.Drawing.Size(213, 183);
            this.gb_CorrBank.TabIndex = 2;
            this.gb_CorrBank.TabStop = false;
            this.gb_CorrBank.Text = "Оптимальный банк";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Выплата в мес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Срок погашения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Банк";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(18, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 21);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(18, 99);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 21);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 21);
            this.textBox5.TabIndex = 1;
            // 
            // dGV_TOP
            // 
            this.dGV_TOP.AllowUserToAddRows = false;
            this.dGV_TOP.AllowUserToDeleteRows = false;
            this.dGV_TOP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV_TOP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dGV_TOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_TOP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bank,
            this.Percent,
            this.Karma});
            this.dGV_TOP.Location = new System.Drawing.Point(16, 39);
            this.dGV_TOP.Name = "dGV_TOP";
            this.dGV_TOP.ReadOnly = true;
            this.dGV_TOP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_TOP.RowTemplate.Height = 23;
            this.dGV_TOP.Size = new System.Drawing.Size(344, 145);
            this.dGV_TOP.TabIndex = 3;
            // 
            // Bank
            // 
            this.Bank.HeaderText = "Банк";
            this.Bank.Name = "Bank";
            this.Bank.ReadOnly = true;
            this.Bank.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Процент годовых";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Karma
            // 
            this.Karma.HeaderText = "Балл доверия";
            this.Karma.Name = "Karma";
            this.Karma.ReadOnly = true;
            this.Karma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(34, 231);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(220, 37);
            this.pBar.TabIndex = 4;
            // 
            // gb_TOP
            // 
            this.gb_TOP.Controls.Add(this.dGV_TOP);
            this.gb_TOP.Location = new System.Drawing.Point(282, 212);
            this.gb_TOP.Name = "gb_TOP";
            this.gb_TOP.Size = new System.Drawing.Size(376, 217);
            this.gb_TOP.TabIndex = 3;
            this.gb_TOP.TabStop = false;
            this.gb_TOP.Text = "ТОП-5 банков (высокие проценты)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 412);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Учитывать доверие к банку";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_BankList
            // 
            this.btn_BankList.Location = new System.Drawing.Point(61, 342);
            this.btn_BankList.Name = "btn_BankList";
            this.btn_BankList.Size = new System.Drawing.Size(155, 23);
            this.btn_BankList.TabIndex = 6;
            this.btn_BankList.Text = "Список банков";
            this.btn_BankList.UseVisualStyleBackColor = true;
            this.btn_BankList.Click += new System.EventHandler(this.btn_BankList_Click);
            // 
            // BanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 441);
            this.Controls.Add(this.btn_BankList);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gb_TOP);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.gb_CorrBank);
            this.Controls.Add(this.gb_MyValues);
            this.Controls.Add(this.btn_CorrBank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(684, 477);
            this.MinimumSize = new System.Drawing.Size(684, 477);
            this.Name = "BanksForm";
            this.Text = "Поиск оптимального банка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_MyValues.ResumeLayout(false);
            this.gb_MyValues.PerformLayout();
            this.gb_CorrBank.ResumeLayout(false);
            this.gb_CorrBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TOP)).EndInit();
            this.gb_TOP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CorrBank;
        private System.Windows.Forms.GroupBox gb_MyValues;
        private System.Windows.Forms.GroupBox gb_CorrBank;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.GroupBox gb_TOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Karma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_BankList;
        public System.Windows.Forms.DataGridView dGV_TOP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

