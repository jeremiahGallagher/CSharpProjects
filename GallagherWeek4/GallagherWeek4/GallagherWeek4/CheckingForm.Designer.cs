namespace GallagherWeek4
{
    partial class NewCheckingForm
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
            this.depositText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createChAcctBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depositText
            // 
            this.depositText.Location = new System.Drawing.Point(24, 145);
            this.depositText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depositText.Name = "depositText";
            this.depositText.Size = new System.Drawing.Size(148, 31);
            this.depositText.TabIndex = 0;
            this.depositText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount to deposit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter an amount greater than zero";
            // 
            // feeText
            // 
            this.feeText.Location = new System.Drawing.Point(24, 383);
            this.feeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feeText.Name = "feeText";
            this.feeText.Size = new System.Drawing.Size(148, 31);
            this.feeText.TabIndex = 3;
            this.feeText.TextChanged += new System.EventHandler(this.feeText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaction Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please enter the Associated Fee ";
            // 
            // createChAcctBtn
            // 
            this.createChAcctBtn.Enabled = false;
            this.createChAcctBtn.Location = new System.Drawing.Point(291, 441);
            this.createChAcctBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createChAcctBtn.Name = "createChAcctBtn";
            this.createChAcctBtn.Size = new System.Drawing.Size(112, 36);
            this.createChAcctBtn.TabIndex = 6;
            this.createChAcctBtn.Text = "Create";
            this.createChAcctBtn.UseVisualStyleBackColor = true;
            this.createChAcctBtn.Click += new System.EventHandler(this.createChAcctBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(442, 441);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 36);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NewCheckingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 495);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createChAcctBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositText);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewCheckingForm";
            this.Text = "New Checking Account";
            this.Load += new System.EventHandler(this.CheckingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox depositText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox feeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createChAcctBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}