using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee1
    {
        public int EmployeeID { get; set; }
        public string? Name { get; set; }
        public double PerformanceRating { get; set; }
        public static double BonusCalculation( double performncrate)
        {

            //double bonus = performncrate * 1000;
            //Console.WriteLine("Bonus:");
            //return bonus;
            
            if (performncrate >= 4.0)
            {
                Console.WriteLine("Bonus:");
                return performncrate*1000;
            }
            else
            {
                return performncrate*100;
            }
        }
        public static double CalculateBonus(double performncrate)
        {

            //double bonus = performncrate * 1000*2;
            //Console.WriteLine("Bonus:");
            //return bonus;
            if (performncrate >= 4.0)
            {
                Console.WriteLine("Bonus:");
                return performncrate * 1000*2;
            }
            else
            {
                return performncrate * 100;
            }
        }
    }
}
