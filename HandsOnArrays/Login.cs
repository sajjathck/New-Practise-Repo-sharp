using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Login
    {
        static void Main()
        {
            string[,] loginCred = new string[5, 2]
            {
                {"Faris","12345"},
                {"Amal","12345"},
                {"Jismon","12345"},
                {"Sajjad","12345"},
                {"Bince","12345"},
            };
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (loginCred[i,0]==userName && loginCred[0,i] == pwd)
                {
                    Console.WriteLine("Login Succcesfull");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
