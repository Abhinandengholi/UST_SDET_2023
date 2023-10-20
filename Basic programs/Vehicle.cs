using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal abstract class Vehicle
    {
        public int Vehnum { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public abstract string? setTypeForVeh();
        public void Disp()
        {
            //Console.WriteLine(Vehnum + " " + Brand + " " + Model);
            Console.WriteLine("Vehiclenum :{0}\n BRAND :{1}\n Type :{2}", Vehnum,Brand,Model);
        }

            }
}
