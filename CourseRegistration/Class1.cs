using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    internal class CourseRegistration 
    {
        private string studentName;
        private int creditHours;
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student name cannot be empty.");
                }
                studentName = value;

            }
        }
        public int CreditHours
        {
            get
            {
                return creditHours;
            }
            set
            {
                if (value <1|| value >21)
                {
                    throw new ArgumentException("credit hours moust be between 1 and 21");
                }
                creditHours = value;
            }
        }
        public CourseRegistration():this("Unknown",1)
            {
            }
public CourseRegistration(string name):this(name,1)
        {
        }
        public CourseRegistration(string name ,int hours)
        {
            StudentName = name;
            CreditHours = hours;
        }
    }
}




