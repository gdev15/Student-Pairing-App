using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Pairing_Application
{
    public class Students : Groups
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

        public override string ToString()
        {
            return $"Name:{Name}\nStudentId:{StudentId}\n";
        }
    }
}
