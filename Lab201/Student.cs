using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string name;
        private string StudentID;
        private int Year_Of_Birth;
        private bool Status;
        public int todayyears = DateTime.Now.Year;


        //function (Methods)
        public Student()
        {
            name = "John Doe";
            Status= false;
            Year_Of_Birth = 1995;
            StudentID = "Unknown";
        }
        public Student(string name, string StudentID)
        {

            this.name = name;
            this.StudentID = StudentID;
            Year_Of_Birth = 1995;
            Status = true;

        }
        public Student(string name, string StudentID, int Year_Of_Birth)
        {
            this.name = name;
            this.StudentID = StudentID;
            this.Year_Of_Birth = Year_Of_Birth;
            Status = true;

        }
        public Student(string name, string StudentID, int Year_Of_Birth, bool status)
        {
            this.name = name;
            this.StudentID = StudentID;
            this.Year_Of_Birth = Year_Of_Birth;
            this.Status = status;

        }

        public string Name
        {
            get
            { return name; }
            set
            {
                name = value;
            }
        }

        public void setStudentID(string StudentID)
        {
            this.StudentID = StudentID;

        }
        public string getStudentID()
        {

            return "";
        }
        public int YearOfBirth
        {
            get {
                return Year_Of_Birth;
            }
            set
            {
                int x = Year_Of_Birth;
                Year_Of_Birth = value;
                if (Year_Of_Birth >= 1950 && Year_Of_Birth <= 2000)
                {
                    Year_Of_Birth = value;
                }
                else
                {

                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", this.StudentID);

                    Year_Of_Birth = x;
                }
            }
        }

        public bool isActive
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }
        public override string ToString()
        {
            string x;
            if (Status == true)
                x = "is";
            else
            {
                x = "is NOT";
            }
            return "[Student : " + name + "(" + StudentID + ")" + ", Age = " + (todayyears - Year_Of_Birth) + ",  " + x + " active Stdent]";


        }

    }
}
