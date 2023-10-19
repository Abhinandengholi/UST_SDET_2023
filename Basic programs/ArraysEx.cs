using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class ArraysEx
    {
        int[] numbers = new int[5];       // = { 10, 20, 30 };
        int[,] nums = new int[2, 2];
        public void Onedim()
        {

            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("2nd");
            numbers[1] = 123;
            //Array.Clear(numbers);
            //Array.Sort(numbers);
            foreach (var num in numbers)
            {

                Console.WriteLine(num);
            }

        }
        public void Twodim()
        {

            /*nums[0, 0] = 10;
            nums[0, 1] = 20;
            nums[1, 0] = 30;
            nums[1, 1] = 30;*/
            int[,] nums= { { 100, 200 }, { 300, 400 } };
            foreach (int num in nums)
            {

                Console.WriteLine(num);
            }

        }
        public void Ja()
        {
            int[][,] arr = new int[][,]
                {new int[,]{ { 1,2},{ 3,4}} ,
                new int[,]{ { 100, 200 },  {300,400},{1000,2000} },
                new int[,]{ { 7,8,8},{ 3,1,7},{ 0,6,8} },
                new int[,]{ {11,22},{ 99,88},{0,9 }}
                };
            for (int i = 0; i < arr.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x); j++) {

                    for (int k = 0; k < arr[j].Rank; k++) {
                        Console.Write   (arr[i][j, k] + " ");
                }
                Console.WriteLine();
            }
            x++;
            Console.WriteLine();
        }
           

        }
    }
}
