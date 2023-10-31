using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LinqExmple
    {
        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("C tutorials");
            courses.Add("C++ tutorials");
            courses.Add("Java tutorials");
            courses.Add("Web tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");

            //var result=from c in courses//query syntax
            //           where c.Equals("UI Exp")
            //           select c;
            //var result = courses.Where(c =>c.Equals( "UI Exp"));//method syntax
            var result = courses.Where(c => c.Contains("tutorial"));

            foreach (var c in result)
            {
                Console.WriteLine(c);
            }

        }
        public void eg2()
        {

            List<Student> students = new List<Student>();
            students.Add(new Student(1,"Abhi","ECE"));
            students.Add(new Student(2, "Adhi", "CSE"));
            students.Add(new Student(3, "Ajhi", "ECE"));
            students.Add(new Student(4, "Akhi", "CSE"));
            students.Add(new Student(5, "Aghi", "CSE"));


            var stud = students.Where(s => s.Id == 3);
            foreach (var s in stud)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Dept);
            }



            Student studen = (Student)students.FirstOrDefault(s => s.Id == 1);//can't use where
            if (stud != null)
            {
                Console.WriteLine("Student:" + studen.Id + " " + studen.Name + " " + studen.Dept);

            }
            else {
                Console.WriteLine("NFound"); 
            }



                
            List<Student> studen1 = students.FindAll(s => s.Dept == "Ajhi" || s.Name == "BB");
            foreach (var sd in studen1)
            {
                //Console.WriteLine(sd.Id + " " + sd.Name + " " + sd.Dept);
                Console.WriteLine(sd.Id + "\t" + sd.Name +"\t"+sd.Dept);
            }

        }
        public void filteringOfType()
        {

            ArrayList elements=new ArrayList();
            elements.Add(1);
            elements.Add("Two");
            elements.Add(2);
            elements.Add(3);
            elements.Add("Five");


            var numbers=elements.OfType<int>();
            var strings = elements.OfType<string>();

            foreach(string str in strings)
                Console.WriteLine("string:"+str);
            foreach (int num in numbers)
                Console.WriteLine("integers:" + num);

        }
        public void SortStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Abhi", "ECE"));
            students.Add(new Student(2, "Adhi", "CSE"));
            students.Add(new Student(3, "Ajhi", "ECE"));
            students.Add(new Student(4, "Akhi", "CSE"));
            students.Add(new Student(5, "Aghi", "CSE"));
            var result=students.OrderBy(s=>s.Name).ThenBy(s=>s.Dept);//ThenBy is, if same name it will order by dept
                foreach (var s in result)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Dept);
            }



            var res = students.ToLookup(s => s.Name);
                foreach (var s in res)
            {
                Console.WriteLine(s.Key);
                foreach (var x in s)
                {
                    Console.WriteLine(x.Id + " " + x.Dept);
                }
            }



        }
    }
}
