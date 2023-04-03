using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Student
    {

        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public string Gender { get; set; }

        public int StudyYear { get; set; }

        public string KNum { get; set; }

        public string County { get; set; }

        public string Availability { get; set; }

        public string StudentPhoneNumber { get; set; }


       

        public Student(string Sname, int StAge, string Sgender, int Syear, string kNum, string Scounty, string Savail, string SPhone)
        {
            this.StudentName =" ";
            this.StudentAge = 0;
            this.Gender = " ";
            this.StudyYear = 0;
            this.KNum = " ";
            this.County = " ";
            this.Availability = " ";
            this.StudentPhoneNumber = " ";

        }







    }
}
