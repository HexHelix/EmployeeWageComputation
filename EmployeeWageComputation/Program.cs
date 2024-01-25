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
    }
}
