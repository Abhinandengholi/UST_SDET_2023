﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
       
        public string? student_name;
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
}