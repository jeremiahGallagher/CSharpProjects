namespace GallagherWeek3
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
            this.mainCourseBox = new System.Windows.Forms.GroupBox();
            this.btnSalad = new System.Windows.Forms.RadioButton();
            this.btnPizza = new System.Windows.Forms.RadioButton();
            this.btnBurger = new System.Windows.Forms.RadioButton();
            this.addOnBox = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.orderTotalBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainCourseBox.SuspendLayout();
            this.addOnBox.SuspendLayout();
            this.orderTotalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCourseBox
            // 
            this.mainCourseBox.Controls.Add(this.btnSalad);
            this.mainCourseBox.Controls.Add(this.btnPizza);
            this.mainCourseBox.Controls.Add(this.btnBurger);
            this.mainCourseBox.Location = new System.Drawing.Point(25, 22);
            this.mainCourseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainCourseBox.Name = "mainCourseBox";
            this.mainCourseBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainCourseBox.Size = new System.Drawing.Size(165, 154);
            this.mainCourseBox.TabIndex = 0;
            this.mainCourseBox.TabStop = false;
            this.mainCourseBox.Text = "Main Course";
            this.mainCourseBox.Enter += new System.EventHandler(this.mainCourseBox_Enter);
            // 
            // btnSalad
            // 
            this.btnSalad.AutoSize = true;
            this.btnSalad.Location = new System.Drawing.Point(21, 107);
            this.btnSalad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(65, 21);
            this.btnSalad.TabIndex = 2;
            this.btnSalad.Text = "Salad";
            this.btnSalad.UseVisualStyleBackColor = true;
            this.btnSalad.CheckedChanged += new System.EventHandler(this.btnSalad_CheckedChanged);
            // 
            // btnPizza
            // 
            this.btnPizza.AutoSize = true;
            this.btnPizza.Location = new System.Drawing.Point(21, 71);
            this.btnPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(63, 21);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.CheckedChanged += new System.EventHandler(this.btnPizza_CheckedChanged);
            // 
            // btnBurger
            // 
            this.btnBurger.AutoSize = true;
            this.btnBurger.Checked = true;
            this.btnBurger.Location = new System.Drawing.Point(21, 29);
            this.btnBurger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(100, 21);
            this.btnBurger.TabIndex = 0;
            this.btnBurger.TabStop = true;
            this.btnBurger.Text = "Hamburger";
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.CheckedChanged += new System.EventHandler(this.btnBurger_CheckedChanged);
            // 
            // addOnBox
            // 
            this.addOnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOnBox.Controls.Add(this.checkBox3);
            this.addOnBox.Controls.Add(this.checkBox2);
            this.addOnBox.Controls.Add(this.checkBox1);
            this.addOnBox.Location = new System.Drawing.Point(240, 22);
            this.addOnBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addOnBox.Name = "addOnBox";
            this.addOnBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addOnBox.Size = new System.Drawing.Size(279, 154);
            this.addOnBox.TabIndex = 1;
            this.addOnBox.TabStop = false;
            this.addOnBox.Text = "Add-Ons(.75 cents)";
            this.addOnBox.Enter += new System.EventHandler(this.addOnBox_Enter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(29, 107);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(109, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French Fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(29, 71);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, Mustard, Mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 29);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce, Tomato, Onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // orderTotalBox
            // 
            this.orderTotalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderTotalBox.Controls.Add(this.label3);
            this.orderTotalBox.Controls.Add(this.label2);
            this.orderTotalBox.Controls.Add(this.label1);
            this.orderTotalBox.Controls.Add(this.txtTotal);
            this.orderTotalBox.Controls.Add(this.txtTax);
            this.orderTotalBox.Controls.Add(this.txtSubTotal);
            this.orderTotalBox.Location = new System.Drawing.Point(25, 205);
            this.orderTotalBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderTotalBox.Name = "orderTotalBox";
            this.orderTotalBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderTotalBox.Size = new System.Drawing.Size(280, 154);
            this.orderTotalBox.TabIndex = 1;
            this.orderTotalBox.TabStop = false;
            this.orderTotalBox.Text = "Order Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax  (7.75%) ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.Location = new System.Drawing.Point(147, 118);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTax.Location = new System.Drawing.Point(147, 84);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(93, 22);
            this.txtTax.TabIndex = 1;
            this.txtTax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Location = new System.Drawing.Point(147, 49);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(93, 22);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(387, 212);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(133, 51);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Place Oder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(387, 307);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 384);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.orderTotalBox);
            this.Controls.Add(this.addOnBox);
            this.Controls.Add(this.mainCourseBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lunch Order";
            this.mainCourseBox.ResumeLayout(false);
            this.mainCourseBox.PerformLayout();
            this.addOnBox.ResumeLayout(false);
            this.addOnBox.PerformLayout();
            this.orderTotalBox.ResumeLayout(false);
            this.orderTotalBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainCourseBox;
        private System.Windows.Forms.RadioButton btnSalad;
        private System.Windows.Forms.RadioButton btnPizza;
        private System.Windows.Forms.RadioButton btnBurger;
        private System.Windows.Forms.GroupBox addOnBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox orderTotalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
    }
}

