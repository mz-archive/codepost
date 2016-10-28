namespace BanksApp
{
    partial class Bank_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank_List));
            this.dGV_MAIN = new System.Windows.Forms.DataGridView();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_AddNewBank = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_DeleteBank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_MAIN)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_MAIN
            // 
            this.dGV_MAIN.AllowUserToAddRows = false;
            this.dGV_MAIN.AllowUserToDeleteRows = false;
            this.dGV_MAIN.AllowUserToResizeColumns = false;
            this.dGV_MAIN.AllowUserToResizeRows = false;
            this.dGV_MAIN.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_MAIN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b,
            this.p,
            this.d});
            this.dGV_MAIN.Location = new System.Drawing.Point(12, 194);
            this.dGV_MAIN.Name = "dGV_MAIN";
            this.dGV_MAIN.ReadOnly = true;
            this.dGV_MAIN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_MAIN.RowTemplate.Height = 23;
            this.dGV_MAIN.Size = new System.Drawing.Size(341, 392);
            this.dGV_MAIN.TabIndex = 0;
            // 
            // b
            // 
            this.b.HeaderText = "Банк";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // p
            // 
            this.p.HeaderText = "Процент";
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // d
            // 
            this.d.HeaderText = "Доверие";
            this.d.Name = "d";
            this.d.ReadOnly = true;
            this.d.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Банк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Доверие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 21);
            this.textBox3.TabIndex = 4;
            // 
            // btn_AddNewBank
            // 
            this.btn_AddNewBank.Location = new System.Drawing.Point(16, 147);
            this.btn_AddNewBank.Name = "btn_AddNewBank";
            this.btn_AddNewBank.Size = new System.Drawing.Size(128, 25);
            this.btn_AddNewBank.TabIndex = 5;
            this.btn_AddNewBank.Text = "Добавить Банк";
            this.btn_AddNewBank.UseVisualStyleBackColor = true;
            this.btn_AddNewBank.Click += new System.EventHandler(this.btn_AddNewBank_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название банка:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 21);
            this.textBox4.TabIndex = 4;
            // 
            // btn_DeleteBank
            // 
            this.btn_DeleteBank.Location = new System.Drawing.Point(199, 113);
            this.btn_DeleteBank.Name = "btn_DeleteBank";
            this.btn_DeleteBank.Size = new System.Drawing.Size(130, 21);
            this.btn_DeleteBank.TabIndex = 7;
            this.btn_DeleteBank.Text = "Удалить банк";
            this.btn_DeleteBank.UseVisualStyleBackColor = true;
            this.btn_DeleteBank.Click += new System.EventHandler(this.btn_DeleteBank_Click);
            // 
            // Bank_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 592);
            this.Controls.Add(this.btn_DeleteBank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddNewBank);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_MAIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(372, 628);
            this.MinimumSize = new System.Drawing.Size(372, 628);
            this.Name = "Bank_List";
            this.Text = "Список всех банков";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_MAIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_MAIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_AddNewBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_DeleteBank;
    }
}