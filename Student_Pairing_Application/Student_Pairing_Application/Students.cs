using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Pairing_Application
{
    public class Students
    {
        //fields

        //props
        public string Name { get; set; }
        public int StudentId { get; set; }

        //ctors

        //methods
        public Students() { }
        public Students(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }
    }
}
