namespace Student_Pairing_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            string StudentNames = "Leo,Raph,Mike,Don,April,Splinter";
            Students[] students = Groups.CreateStudentArray(StudentNames);
            //Console.WriteLine(students[0]);

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            var newRandomArray = Random[](0, students.Length);
        }
    }
}