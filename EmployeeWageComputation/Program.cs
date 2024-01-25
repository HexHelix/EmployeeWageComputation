using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Press 1 for Employee wage and 2 for part time employee wage");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine(CalcEmpWage());
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(PartTimeWage());
                    }
                    break;
                default: Console.WriteLine("Either press 1 or 2");
                    break;
            }
        }

        static bool IsPresent()
        {
            Random rnd = new Random();
            return Convert.ToBoolean(rnd.Next(0,2));
        }

        static int CalcEmpWage()
        {
            int WagePerHour = 20;
            int FullDayHour = 8;
            return WagePerHour* FullDayHour;
        }

        static int PartTimeWage()
        {
            int WagePerHour = 20;
            int FullDayHour = 4;
            return WagePerHour * FullDayHour;
        }
    }
}
