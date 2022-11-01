using System;

namespace ConsoleDi
{
    public class TeacherService : IService
    {
        public void GetFirstName()
        {
            Console.WriteLine("Teacher First Name");
        }

        public void GetLastName()
        {
            Console.WriteLine("Teacher Last Name");
        }
    }
}
