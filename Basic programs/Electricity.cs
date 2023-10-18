using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    class Electricity
    {
        public int consumernumber, previousreading, currentreading;
           public string? consumername;
        /*public Electricity() {
            consumernumber = 12345;
            previousreading = ;
            currentreading = 0;
            consumername= String.Empty;
        }*/
        
        public Electricity(int consumernumber, int previousreading, int currentreading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.previousreading = previousreading;
            this.currentreading = currentreading;
            this.consumername = consumername;
        }

        public double CalculateBill()
        { double billamount ;
                int reading = currentreading - previousreading;
            if (reading <= 100) {
                billamount = reading * 2.00;
            }
            else if(reading<=201&&reading>=101){
                billamount = (100 * 2) + ((reading - 100) * 2.5);
                

            }
            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
                                
            }
            else 
            {
                billamount = (100 * 2) + (100 * 2.5) + (100* 3.5)+((reading - 400) * 5.00);

            }
            return billamount;

        }
    }
}
