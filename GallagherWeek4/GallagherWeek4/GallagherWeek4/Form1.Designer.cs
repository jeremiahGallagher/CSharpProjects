namespace GallagherWeek4
{
    partial class Form1
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxSummary = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.pnlNewAcct = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radBtnSavings = new System.Windows.Forms.RadioButton();
            this.radBtnChecking = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.boxSummary.SuspendLayout();
            this.pnlNewAcct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(17, 163);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 46);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 59);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Accounts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 189);
            this.panel1.TabIndex = 5;
            // 
            // boxSummary
            // 
            this.boxSummary.Controls.Add(this.textBox2);
            this.boxSummary.Controls.Add(this.label3);
            this.boxSummary.Controls.Add(this.textBox1);
            this.boxSummary.Controls.Add(this.label2);
            this.boxSummary.Location = new System.Drawing.Point(394, 77);
            this.boxSummary.Name = "boxSummary";
            this.boxSummary.Size = new System.Drawing.Size(301, 239);
            this.boxSummary.TabIndex = 6;
            this.boxSummary.TabStop = false;
            this.boxSummary.Text = "Account Summary";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Balance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(314, 516);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(204, 59);
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Create New Acct";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // pnlNewAcct
            // 
            this.pnlNewAcct.Controls.Add(this.label4);
            this.pnlNewAcct.Controls.Add(this.radBtnSavings);
            this.pnlNewAcct.Controls.Add(this.radBtnChecking);
            this.pnlNewAcct.Controls.Add(this.btnSelect);
            this.pnlNewAcct.Location = new System.Drawing.Point(39, 287);
            this.pnlNewAcct.Name = "pnlNewAcct";
            this.pnlNewAcct.Size = new System.Drawing.Size(212, 265);
            this.pnlNewAcct.TabIndex = 8;
            this.pnlNewAcct.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Type";
            // 
            // radBtnSavings
            // 
            this.radBtnSavings.AutoSize = true;
            this.radBtnSavings.Location = new System.Drawing.Point(17, 99);
            this.radBtnSavings.Name = "radBtnSavings";
            this.radBtnSavings.Size = new System.Drawing.Size(120, 29);
            this.radBtnSavings.TabIndex = 1;
            this.radBtnSavings.TabStop = true;
            this.radBtnSavings.Text = "Savings";
            this.radBtnSavings.UseVisualStyleBackColor = true;
            // 
            // radBtnChecking
            // 
            this.radBtnChecking.AutoSize = true;
            this.radBtnChecking.Location = new System.Drawing.Point(17, 64);
            this.radBtnChecking.Name = "radBtnChecking";
            this.radBtnChecking.Size = new System.Drawing.Size(133, 29);
            this.radBtnChecking.TabIndex = 0;
            this.radBtnChecking.TabStop = true;
            this.radBtnChecking.Text = "Checking";
            this.radBtnChecking.UseVisualStyleBackColor = true;
            this.radBtnChecking.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(17, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 79);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.pnlNewAcct);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.boxSummary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Bank Accounts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.boxSummary.ResumeLayout(false);
            this.boxSummary.PerformLayout();
            this.pnlNewAcct.ResumeLayout(false);
            this.pnlNewAcct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox boxSummary;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Panel pnlNewAcct;
        private System.Windows.Forms.RadioButton radBtnSavings;
        private System.Windows.Forms.RadioButton radBtnChecking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

