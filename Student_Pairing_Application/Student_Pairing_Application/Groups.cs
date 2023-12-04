using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Pairing_Application
{
    public class Groups 
    {
        public static Students[] CreateStudentArray(string studentNames)
        {
            string[] names = studentNames.Split(',');
            Students[] students = new Students[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                students[i] = new Students { Name = names[i].Trim(), StudentId = i + 1 };
            }
            return students;
        } 
    }
}
