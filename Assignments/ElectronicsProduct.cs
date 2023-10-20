using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicsProduct : Product
    {
        public ElectronicsProduct(string? prouductName, double price, int quantity,int warrentyperiod) : base(prouductName, price, quantity)
        {
            WarrentyPeriod = warrentyperiod;
        }


        
        public int WarrentyPeriod { get; set; }
        public void DisplayWarrentyPeriod()
        {
            Console.WriteLine("Warrenty period:" + WarrentyPeriod);
        }
    } }

