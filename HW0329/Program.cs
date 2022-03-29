using System;

namespace HW0329
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            Console.WriteLine("Istifadeci adini daxil et:");
            username= Console.ReadLine();
            Console.WriteLine("Passwordu daxil et:");
            password = Console.ReadLine();
       

            User user = new User(username);
            user.UserName = username;
            user.Password = password;
            Console.WriteLine($"USERNAME:{user.UserName}\nPASSWORD:{user.Password}");
            Console.WriteLine(user.HasUpper("user"));
            Console.WriteLine(user.HasDigit(username));
            Console.WriteLine(user .HasLower ("ASEDRF"));


            #region ClassWork

            //
            string fullName;
            string groupNo;
            Console.WriteLine("Telebenin ad ve soyadi:");
            fullName = Console.ReadLine();
            Console.WriteLine("telebenin qrupu:");
            groupNo= Console.ReadLine();

            Student student = new Student();
                student.FullName = fullName;
                student.GroupNo = groupNo;
            Console.WriteLine($"Telebenin ad ve soyadi:{student .FullName }\nQrup nomresi:{student.GroupNo}");



            #endregion

        }
    }
}
