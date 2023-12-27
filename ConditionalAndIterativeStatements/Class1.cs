﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalAndIterativeStatements
{
    internal class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter No");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            do
            {
                Console.WriteLine("1.Even/Odd");
                Console.WriteLine("2.Natural No's");
                Console.WriteLine("3.Math Table");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter Choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            //Even or Odd
                            // if (n % 2 == 0) Console.WriteLine("Even"); else Console.WriteLine("Odd");
                            string result = n % 2 == 0 ? "Even" : "Odd";
                            Console.WriteLine(result);
                        }
                        break;
                    case 2:
                        { //Natural no's
                            int count = 1;
                            while (count <= n)
                            {
                                Console.WriteLine(count);
                                count++;
                            }
                            break;
                        }
                    case 3: //Math Table
                        {
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine($"{n}*{i}={n * i}");
                            }
                        }
                        break;
                    case 4:
                        //Environment.Exit(0); //exit the application
                        flag=false;
                        break;
                    default:
                        Console.WriteLine("Enter Choice between 1 to 4");
                        break;
                }
            } while (flag == true);
        }
    }
 }
