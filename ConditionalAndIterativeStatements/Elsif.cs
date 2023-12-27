﻿namespace ConditionalAndIterativeStatements
{
    internal class Elsif
    {
        static void Main()
        {
            byte m1 = 78, m2 = 89, m3 = 66, m4 = 56, m5 = 90, m6 = 77;
            int total = (m1 + m2 + m3 + m4 + m5 + m6);
            float avg = total / 6;
            string? grade;
            if (avg >= 70)
            {
                grade = "First Class";
            }
            else if (avg > 60 && avg <= 69)
            {
                grade = "Second Class";
            }
            else if (avg > 50 && avg <= 59)
            {
                grade = "Third Class";
            }
            else
            {
                grade = "Fail";
            }
            if (grade == "Fail")
            {
                Console.WriteLine("Sorry You are Fail!!");
            }
            else
            {
                Console.WriteLine($"Result:{grade} Total Marks:{total} Percentage:{avg}%");
            }
        }
    }
}
