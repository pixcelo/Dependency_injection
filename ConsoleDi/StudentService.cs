using System;

namespace ConsoleDi
{
    public class StudentService : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Student First Name");
        }

        public void GetLastName()
        {
            Console.WriteLine("Student Last Name");
        }
    }
}
