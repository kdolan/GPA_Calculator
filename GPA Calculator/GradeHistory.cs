using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace GPA_Calculator
{
    public partial class GradeHistory : Form
    {
        public GradeHistory()
        {
            InitializeComponent();
        }

        private void GradeHistory_Load(object sender, EventArgs e)
        {

        }

        private void btn_addToHistory_Click(object sender, EventArgs e)
        {
            //Validate Data
            int credits;
            try
            {
                credits = int.Parse(txtBx_credits.Text);
            }
            catch
            {
                return;
            }
            string letterGrade = txtBx_grade.Text;

            Class newClass = new Class(txtBx_className.Text, credits, letterGrade);
            List<Class> historicClasses;
            try
            {
                historicClasses = DataIO.LoadHistoricClasses();
            }
            catch
            {
                //Could not seralzie. New empty list
                historicClasses = new List<Class>();  
            }
            historicClasses.Add(newClass);
            DataIO.SaveHistoricClasses(historicClasses);
            txtBx_credits.Text = "0";
            txtBx_grade.Text = "";
            txtBx_className.Text = "Class Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataIO.SaveHistoricClasses(new List<Class>());
        }
    }
}
