namespace GPA_Calculator
{
    partial class GradeHistory
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
            this.txtBx_grade = new System.Windows.Forms.ComboBox();
            this.txtBx_credits = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_class1 = new System.Windows.Forms.Label();
            this.btn_addToHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBx_className = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBx_grade
            // 
            this.txtBx_grade.FormattingEnabled = true;
            this.txtBx_grade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.txtBx_grade.Location = new System.Drawing.Point(315, 29);
            this.txtBx_grade.Name = "txtBx_grade";
            this.txtBx_grade.Size = new System.Drawing.Size(30, 21);
            this.txtBx_grade.TabIndex = 17;
            // 
            // txtBx_credits
            // 
            this.txtBx_credits.Location = new System.Drawing.Point(255, 29);
            this.txtBx_credits.Mask = "##";
            this.txtBx_credits.Name = "txtBx_credits";
            this.txtBx_credits.PromptChar = '#';
            this.txtBx_credits.Size = new System.Drawing.Size(19, 20);
            this.txtBx_credits.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Credits";
            // 
            // lbl_class1
            // 
            this.lbl_class1.AutoSize = true;
            this.lbl_class1.Location = new System.Drawing.Point(12, 33);
            this.lbl_class1.Name = "lbl_class1";
            this.lbl_class1.Size = new System.Drawing.Size(88, 13);
            this.lbl_class1.TabIndex = 13;
            this.lbl_class1.Text = "Completed Class:";
            // 
            // btn_addToHistory
            // 
            this.btn_addToHistory.Location = new System.Drawing.Point(250, 57);
            this.btn_addToHistory.Name = "btn_addToHistory";
            this.btn_addToHistory.Size = new System.Drawing.Size(96, 23);
            this.btn_addToHistory.TabIndex = 18;
            this.btn_addToHistory.Text = "Add to History";
            this.btn_addToHistory.UseVisualStyleBackColor = true;
            this.btn_addToHistory.Click += new System.EventHandler(this.btn_addToHistory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBx_className
            // 
            this.txtBx_className.Location = new System.Drawing.Point(106, 29);
            this.txtBx_className.Name = "txtBx_className";
            this.txtBx_className.Size = new System.Drawing.Size(130, 20);
            this.txtBx_className.TabIndex = 30;
            this.txtBx_className.Text = "Class Name";
            // 
            // GradeHistory
            // 
            this.AcceptButton = this.btn_addToHistory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 92);
            this.Controls.Add(this.txtBx_className);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addToHistory);
            this.Controls.Add(this.txtBx_grade);
            this.Controls.Add(this.txtBx_credits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_class1);
            this.Name = "GradeHistory";
            this.Text = "Grade History";
            this.Load += new System.EventHandler(this.GradeHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtBx_grade;
        private System.Windows.Forms.MaskedTextBox txtBx_credits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_class1;
        private System.Windows.Forms.Button btn_addToHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBx_className;
    }
}