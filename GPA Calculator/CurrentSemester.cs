using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class CurrentSemester : Form
    {
        public CurrentSemester()
        {
            InitializeComponent();
            List<Class> currentClasses = DataIO.LoadCurrentClasses();
            List<TextBox> classNames = new List<TextBox> { name1, name2, name3, name4, name5, name6 };
            List<MaskedTextBox> credits = new List<MaskedTextBox>{credits1, credits2, credits3, credits4, credits5, credits6};
            List<ComboBox> grades = new List<ComboBox> { grade1, grade2, grade3, grade4, grade5, grade6 };
            int i = 0;
            foreach (Class elementClass in currentClasses)
            {
                classNames[i].Text = elementClass.Name;
                credits[i].Text = elementClass.Credits.ToString();
                grades[i].Text = Class.pointsToGradeDict[elementClass.Grade];
                i++;
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            calculateGPA();
        }

        private void btn_gradeHistory_Click(object sender, EventArgs e)
        {
            Form history = new GradeHistory();
            history.Show();
        }

        private float calculateGPA(List<Class> classes)
        {
            float creditsTotal = 0;
            float gpaPointsTotal = 0;
            foreach(Class elementClass in classes)
            {
                creditsTotal += elementClass.Credits;
                gpaPointsTotal += elementClass.Credits * elementClass.Grade;
            }
            return gpaPointsTotal / creditsTotal;
        }

        private void calculateGPA()
        {
            List<string> creditsList = new List<string> { credits1.Text, credits2.Text, credits3.Text, credits4.Text, credits5.Text, credits6.Text };
            List<string> gradeList = new List<string> { grade1.Text, grade2.Text, grade3.Text, grade4.Text, grade5.Text, grade6.Text };
            List<string> nameList = new List<string> { name1.Text, name2.Text, name3.Text, name4.Text, name5.Text, name6.Text };

            List<Class> currentClasses = new List<Class>();
            for (int i = 0; i < 6; i++)
            {
                int credits;
                try
                {
                    credits = int.Parse(creditsList[i]);
                }
                catch
                {
                    break;
                }
                string letterGrade = gradeList[i];

                Class newClass = new Class(nameList[i], credits, letterGrade);
                currentClasses.Add(newClass);
            }
            DataIO.SaveCurrentClasses(currentClasses);
            List<Class> allClasses = DataIO.LoadHistoricClasses(); //Start with historic classes
            allClasses.AddRange(currentClasses); //Adds current classes

            float semesterGPA = calculateGPA(currentClasses);
            float cumGPA = calculateGPA(allClasses);

            statusLbl_semesterGPA.Text = semesterGPA.ToString("F3");
            statusLbl_cumGPA.Text = cumGPA.ToString("F3");
        }

        private void CurrentSemester_Load(object sender, EventArgs e)
        {
            calculateGPA();
        }
    }
}
