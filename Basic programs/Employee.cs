using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class Employee
    {
        private int empid;
        private string? empname, empdept;
        private double basicpay;
        //private readonly

        public Employee(int empid, string empname, string empdept, double basicpay)
        {
            Empid = empid;
            Empname = empname;
            Empdept = empdept;
            Basicpay = basicpay;
            
        }

        public int Empid { get => empid; set => empid = value; }
        public string? Empname { get => empname; set => empname = value; }
        public string? Empdept { get => empdept; set => empdept = value; }
        public double Basicpay { get => basicpay; set => basicpay = value; }

        //public int Empid { get => empid; set => empid = value; } //properties are also method,

        public double CalculateSalary() {

            double grosssalary, netsalary;
            double allowances = Basicpay * 0.3 + Basicpay  * 0.2 + Basicpay * 0.15;//basicpay properties
            grosssalary = Basicpay + allowances;
            double deduction = Basicpay * 0.1;
            netsalary = grosssalary - deduction;
            return netsalary;
        }
    }
}
