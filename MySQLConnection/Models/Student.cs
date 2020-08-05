using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLConnection.Models
{
    public class Student
    {
        public string EnrolmentNumber { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string FAtherID { get; set; }
        public string BFormNumber { get; set; }

        //Students father/Gaurdian Contact number
        public string Contact { get; set; }

        //Date of Admission
        public string DOA { get; set; }

        //Date of Birth
        public string DOB { get; set; }

        //Student's home address
        public string Address { get; set; }

        //Student's Cast
        public string Cast { get; set; }

        //Student's Religion
        public string Religion { get; set; }


    }
}
