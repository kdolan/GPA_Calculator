namespace GPA_Calculator
{
    partial class CurrentSemester
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
            this.btn_gradeHistory = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_semesterGpa = new System.Windows.Forms.Label();
            this.lbl_cumGPA = new System.Windows.Forms.Label();
            this.statusLbl_semesterGPA = new System.Windows.Forms.Label();
            this.statusLbl_cumGPA = new System.Windows.Forms.Label();
            this.lbl_class1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.credits1 = new System.Windows.Forms.MaskedTextBox();
            this.grade1 = new System.Windows.Forms.ComboBox();
            this.grade2 = new System.Windows.Forms.ComboBox();
            this.credits2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grade3 = new System.Windows.Forms.ComboBox();
            this.credits3 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grade6 = new System.Windows.Forms.ComboBox();
            this.credits6 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grade5 = new System.Windows.Forms.ComboBox();
            this.credits5 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grade4 = new System.Windows.Forms.ComboBox();
            this.credits4 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.name4 = new System.Windows.Forms.TextBox();
            this.name5 = new System.Windows.Forms.TextBox();
            this.name6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_gradeHistory
            // 
            this.btn_gradeHistory.Location = new System.Drawing.Point(12, 242);
            this.btn_gradeHistory.Name = "btn_gradeHistory";
            this.btn_gradeHistory.Size = new System.Drawing.Size(101, 23);
            this.btn_gradeHistory.TabIndex = 19;
            this.btn_gradeHistory.Text = "Grade History";
            this.btn_gradeHistory.UseVisualStyleBackColor = true;
            this.btn_gradeHistory.Click += new System.EventHandler(this.btn_gradeHistory_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(208, 242);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(106, 23);
            this.btn_calculate.TabIndex = 18;
            this.btn_calculate.Text = "Calculate GPA";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_semesterGpa
            // 
            this.lbl_semesterGpa.AutoSize = true;
            this.lbl_semesterGpa.Location = new System.Drawing.Point(191, 192);
            this.lbl_semesterGpa.Name = "lbl_semesterGpa";
            this.lbl_semesterGpa.Size = new System.Drawing.Size(79, 13);
            this.lbl_semesterGpa.TabIndex = 2;
            this.lbl_semesterGpa.Text = "Semester GPA:";
            // 
            // lbl_cumGPA
            // 
            this.lbl_cumGPA.AutoSize = true;
            this.lbl_cumGPA.Location = new System.Drawing.Point(183, 213);
            this.lbl_cumGPA.Name = "lbl_cumGPA";
            this.lbl_cumGPA.Size = new System.Drawing.Size(87, 13);
            this.lbl_cumGPA.TabIndex = 3;
            this.lbl_cumGPA.Text = "Cumulative GPA:";
            // 
            // statusLbl_semesterGPA
            // 
            this.statusLbl_semesterGPA.AutoSize = true;
            this.statusLbl_semesterGPA.Location = new System.Drawing.Point(276, 192);
            this.statusLbl_semesterGPA.Name = "statusLbl_semesterGPA";
            this.statusLbl_semesterGPA.Size = new System.Drawing.Size(13, 13);
            this.statusLbl_semesterGPA.TabIndex = 4;
            this.statusLbl_semesterGPA.Text = "--";
            // 
            // statusLbl_cumGPA
            // 
            this.statusLbl_cumGPA.AutoSize = true;
            this.statusLbl_cumGPA.Location = new System.Drawing.Point(276, 213);
            this.statusLbl_cumGPA.Name = "statusLbl_cumGPA";
            this.statusLbl_cumGPA.Size = new System.Drawing.Size(13, 13);
            this.statusLbl_cumGPA.TabIndex = 5;
            this.statusLbl_cumGPA.Text = "--";
            // 
            // lbl_class1
            // 
            this.lbl_class1.AutoSize = true;
            this.lbl_class1.Location = new System.Drawing.Point(12, 34);
            this.lbl_class1.Name = "lbl_class1";
            this.lbl_class1.Size = new System.Drawing.Size(44, 13);
            this.lbl_class1.TabIndex = 6;
            this.lbl_class1.Text = "Class 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Grade";
            // 
            // credits1
            // 
            this.credits1.Location = new System.Drawing.Point(207, 30);
            this.credits1.Mask = "#";
            this.credits1.Name = "credits1";
            this.credits1.PromptChar = ' ';
            this.credits1.Size = new System.Drawing.Size(19, 20);
            this.credits1.TabIndex = 1;
            // 
            // grade1
            // 
            this.grade1.FormattingEnabled = true;
            this.grade1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.grade1.Location = new System.Drawing.Point(267, 30);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(30, 21);
            this.grade1.TabIndex = 2;
            // 
            // grade2
            // 
            this.grade2.FormattingEnabled = true;
            this.grade2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.grade2.Location = new System.Drawing.Point(267, 56);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(30, 21);
            this.grade2.TabIndex = 5;
            // 
            // credits2
            // 
            this.credits2.Location = new System.Drawing.Point(207, 56);
            this.credits2.Mask = "#";
            this.credits2.Name = "credits2";
            this.credits2.PromptChar = ' ';
            this.credits2.Size = new System.Drawing.Size(19, 20);
            this.credits2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Class 2:";
            // 
            // grade3
            // 
            this.grade3.FormattingEnabled = true;
            this.grade3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.grade3.Location = new System.Drawing.Point(267, 82);
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(30, 21);
            this.grade3.TabIndex = 8;
            // 
            // credits3
            // 
            this.credits3.Location = new System.Drawing.Point(207, 82);
            this.credits3.Mask = "#";
            this.credits3.Name = "credits3";
            this.credits3.PromptChar = ' ';
            this.credits3.Size = new System.Drawing.Size(19, 20);
            this.credits3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Class 3:";
            // 
            // grade6
            // 
            this.grade6.FormattingEnabled = true;
            this.grade6.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.grade6.Location = new System.Drawing.Point(267, 159);
            this.grade6.Name = "grade6";
            this.grade6.Size = new System.Drawing.Size(30, 21);
            this.grade6.TabIndex = 17;
            // 
            // credits6
            // 
            this.credits6.Location = new System.Drawing.Point(207, 159);
            this.credits6.Mask = "#";
            this.credits6.Name = "credits6";
            this.credits6.PromptChar = ' ';
            this.credits6.Size = new System.Drawing.Size(19, 20);
            this.credits6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Class 6:";
            // 
            // grade5
            // 
            this.grade5.FormattingEnabled = true;
            this.grade5.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.grade5.Location = new System.Drawing.Point(267, 134);
            this.grade5.Name = "grade5";
            this.grade5.Size = new System.Drawing.Size(30, 21);
            this.grade5.TabIndex = 14;
            // 
            // credits5
            // 
            this.credits5.Location = new System.Drawing.Point(207, 134);
            this.credits5.Mask = "#";
            this.credits5.Name = "credits5";
            this.credits5.PromptChar = ' ';
            this.credits5.Size = new System.Drawing.Size(19, 20);
            this.credits5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Class 5:";
            // 
            // grade4
            // 
            this.grade4.FormattingEnabled = true;
            this.grade4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.grade4.Location = new System.Drawing.Point(267, 108);
            this.grade4.Name = "grade4";
            this.grade4.Size = new System.Drawing.Size(30, 21);
            this.grade4.TabIndex = 11;
            // 
            // credits4
            // 
            this.credits4.Location = new System.Drawing.Point(207, 108);
            this.credits4.Mask = "#";
            this.credits4.Name = "credits4";
            this.credits4.PromptChar = ' ';
            this.credits4.Size = new System.Drawing.Size(19, 20);
            this.credits4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Class 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Name";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(62, 30);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(126, 20);
            this.name1.TabIndex = 0;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(62, 56);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(126, 20);
            this.name2.TabIndex = 3;
            // 
            // name3
            // 
            this.name3.Location = new System.Drawing.Point(62, 82);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(126, 20);
            this.name3.TabIndex = 6;
            // 
            // name4
            // 
            this.name4.Location = new System.Drawing.Point(62, 108);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(126, 20);
            this.name4.TabIndex = 9;
            // 
            // name5
            // 
            this.name5.Location = new System.Drawing.Point(62, 134);
            this.name5.Name = "name5";
            this.name5.Size = new System.Drawing.Size(126, 20);
            this.name5.TabIndex = 12;
            // 
            // name6
            // 
            this.name6.Location = new System.Drawing.Point(62, 159);
            this.name6.Name = "name6";
            this.name6.Size = new System.Drawing.Size(126, 20);
            this.name6.TabIndex = 15;
            // 
            // CurrentSemester
            // 
            this.AcceptButton = this.btn_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 277);
            this.Controls.Add(this.name6);
            this.Controls.Add(this.name5);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grade6);
            this.Controls.Add(this.credits6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grade5);
            this.Controls.Add(this.credits5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grade4);
            this.Controls.Add(this.credits4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grade3);
            this.Controls.Add(this.credits3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grade2);
            this.Controls.Add(this.credits2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.credits1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_class1);
            this.Controls.Add(this.statusLbl_cumGPA);
            this.Controls.Add(this.statusLbl_semesterGPA);
            this.Controls.Add(this.lbl_cumGPA);
            this.Controls.Add(this.lbl_semesterGpa);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_gradeHistory);
            this.Name = "CurrentSemester";
            this.Text = "Current Semester";
            this.Load += new System.EventHandler(this.CurrentSemester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gradeHistory;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_semesterGpa;
        private System.Windows.Forms.Label lbl_cumGPA;
        private System.Windows.Forms.Label statusLbl_semesterGPA;
        private System.Windows.Forms.Label statusLbl_cumGPA;
        private System.Windows.Forms.Label lbl_class1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox credits1;
        private System.Windows.Forms.ComboBox grade1;
        private System.Windows.Forms.ComboBox grade2;
        private System.Windows.Forms.MaskedTextBox credits2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox grade3;
        private System.Windows.Forms.MaskedTextBox credits3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox grade6;
        private System.Windows.Forms.MaskedTextBox credits6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grade5;
        private System.Windows.Forms.MaskedTextBox credits5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox grade4;
        private System.Windows.Forms.MaskedTextBox credits4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.TextBox name4;
        private System.Windows.Forms.TextBox name5;
        private System.Windows.Forms.TextBox name6;
    }
}

