using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class GenericCollection
    {
        public void ListHandling()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(60);
            numbers.Add(66);
            numbers.Add(555);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Reverse();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(3);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Sort();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            //numbers.Clear();
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("contain" + numbers.Contains(555));
            Console.WriteLine(numbers.IndexOf(555));

        }
        public void Stackhandling()
        {
            Stack<int> st = new Stack<int>();
            //Stack st=new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            //st.Push("A");
            st.Push(65);
            st.Push(98);
            foreach (int item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop:" + st.Pop());//instead of pop in stack
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek:" + st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
        public void Queuehandling()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            //q.Enqueue(true);
            //q.Enqueue(false);

            foreach (int item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop:" + q.Dequeue());//instead of pop in stack
            foreach (int item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek:" + q.Peek());
            foreach (int item in q)
            {
                Console.WriteLine(item);
            }



        }
        public void DictionaryHandling()
        {
            Dictionary<int, string> ht = new Dictionary<int, string>();
            //Hashtable ht=new Hashtable();
            ht.Add(1, "A");
            ht.Add(2, "B");
            ht.Add(3, "C");
            ht.Add(4, "D");
            ht.Add(5, "E");
            foreach (int item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            ht.Remove(3);
            Console.WriteLine("removed");
            foreach (int item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ht.ContainsKey(5));
            foreach (int item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (string item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.Write("count:" + ht.Count);

        }
        public void SortedListhandling()
        {
            SortedDictionary<int, string> sl = new SortedDictionary<int, string>();
            //SortedList sl = new SortedList();
            sl.Add(1, "10");
            sl.Add(2, "20");
            sl.Add(3, "30");
            sl.Add(4, "Adi");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }
        }
    }
}

