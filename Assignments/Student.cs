using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {

        /* public string? student_name;
         public int mark1, mark2, mark3;
         public double average;

         public Student(string? student_name, int mark1, int mark2, int mark3)
         {
             this.student_name = student_name;
             this.mark1 = mark1;
             this.mark2 = mark2;
             this.mark3 = mark3;
         }
         public double calculateAverage() {
             double average = (mark1 + mark2 + mark3) / 3;



             return average;
                 }

     }
 }*/
        private string? name, grade;
        int[] mark = new int[3];

        public Student(string? name, string? grade, int[] mark)
        {
            Name = name;
            Grade = grade;
            Mark = mark;
        }

        public string? Name { get => name; set => name = value; }
        public string? Grade { get => grade; set => grade = value; }
        public int[] Mark { get => mark; set => mark = value; }

        public double CalculateAverage()
        {
            double average = Mark.Average();
            Console.WriteLine("Average:" + average);
            return average;


        }
        public void DisplayStudent()
        {
            Console.WriteLine(" Student Name:" + name);
            Console.WriteLine("Grade:" + grade);
            int i = 1, total = 0;
            foreach (int mrk in mark)
            {
                Console.WriteLine("Mark{0}:{1}", i, mrk);
                i++;
                total += mrk;
            }
            Console.WriteLine("Total:" + total);
        }
        public void GetMarkssummary()
        {
            int highest = mark[0];
            int lowest = mark[0];
            foreach (int mrk in mark)
            {
                if (mrk > highest) highest = mrk;
                if (mrk < lowest) lowest = mrk;
            }
            Console.WriteLine("Highest:" + highest);
            Console.WriteLine("Lowest:" + lowest);
        }
    }
}

