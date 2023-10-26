using Basic_programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class ExcepHandling
    {
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1{ get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {
            //try 
            //{
            int[] num = { 10, 20, 30 };
            int result = Num1 / Num2;
            Console.WriteLine(result);
            foreach (var n in num)
            {
                result = n / Num2;
                Console.WriteLine(result);
            }
            for (int i = 0; i <= 3; i++)
            {

                result = num[i] / Num2;
                Console.WriteLine(result);
            }
        }
        public void NumCheck()
        {
            if (Num1 > 100)
            {
                Console.WriteLine("Cngrtz");
            }
            else 
            {
                throw new ArgumentException(MyException.exmessagelist[3]);
       
            }
            if (Num2 < 100)
            {
                Console.WriteLine("Congrtz");
            }
            else
            {
                throw new ArgumentException(MyException.exmessagelist[4]);

            }
            //}
            //catch(ArithmeticException ex) 
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);//check which line have error
            //    //Console.WriteLine(ex.Source);
            //    Console.WriteLine("Don't give zero for denom");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("done");//release memomry,before exiting the code
            //}
        }


    }
}
