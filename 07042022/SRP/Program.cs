using System;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Name-i daxil edin");
            string name = Console.ReadLine();

            UserValidator userValidator = new UserValidator();

            while (!userValidator.CheckUserName(name))
            {
                Console.WriteLine("Name-i duzgun daxil edin");
                name = Console.ReadLine();
            }

            Console.WriteLine("Sifreni daxil edin");
            string password = Console.ReadLine();

            while (!userValidator.CheckPassword(password))
            {
                Console.WriteLine("Sifreni duzgun edin!");
                password = Console.ReadLine();
            }

            UserCRUD userCRUD = new UserCRUD(); 

            user.UserName = name;
            user.Password = password;

            userCRUD.AddUser(user);

            Console.WriteLine(userCRUD.GetUser(0).UserName);

        }
    }
}
