using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GPA_Calculator
{
    [Serializable()]
    public class Class
    {
        public Class(string name, int numCredits, string letterGrade)
        {
            this.credits = numCredits;
            try 
            {
                this.grade = gradeDict[letterGrade];
            }
            catch (KeyNotFoundException)
            {
                this.grade = 0;
            }
            this.name = name;
 
        }

        private string name;
        private int credits;
        private int grade; //A=4,B=3,C=2,D=1,F=0
        private static Dictionary<string, int> gradeDict = new Dictionary<string, int>
        {
            {"A", 4},
            {"B", 3},
            {"C", 2},
            {"D", 1},
            {"F", 0}
        };

        public static Dictionary<int, string> pointsToGradeDict = new Dictionary<int, string>
        {
            {4, "A"},
            {3, "B"},
            {2, "C"},
            {1, "D"},
            {0, "F"}
        };

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
