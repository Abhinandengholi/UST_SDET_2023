using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DigitalProduct : ElectronicsProduct
    {
        

        public DigitalProduct(string? prouductName, double price, int quantity, int warrentyperiod,string? fileformat) : base(prouductName, price, quantity, warrentyperiod)
        {
            FileFormat = fileformat;
        }
        public string? FileFormat { get; set; }
        public void DisplayDigitalProduct()
        {
            Console.WriteLine("FileFormat" + FileFormat);
        }
            }

    }

