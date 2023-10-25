using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class NGC
    {
        public void ArrayListHandling() 
        {
            ArrayList arrayList = new ArrayList();  
            arrayList.Add(10);
            arrayList.Add(20);  
            arrayList.Add(30);  
           // for(int i=0; i<arrayList.Count;i++)
           //foreach(var item in arrayList)
           // { Console.WriteLine(item); }
            arrayList.Add("Abhi");
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Reverse();
            //foreach (var item in arrayList)
            //{ Console.WriteLine(item); }
            //arrayList.Sort();
            // arrayList.RemoveAt(2);
            //foreach (var item in arrayList)
            //{ Console.WriteLine(item); }
            //Console.WriteLine(arrayList.Contains(10));
            //Console.WriteLine(arrayList.IndexOf(20));

        }
        //public void Stackhandling()
          
        //st.Push(10);
        //    st.Push(20);    
        //    st.Push(30);
        //    st.Push("Abhi");
        //    st.Push(12.44);
        //    st.Push(65);
            //st.Push(98);
            public void Queuehandling()
        {
            Queue q =new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(true);
            q.Enqueue(false);
           
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop:" + q.Dequeue());//instead of pop in stack
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek:" + q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + q.Count);
            
        }
        public void HashTableHandling()
        {
            Hashtable htable = new Hashtable();
            htable.Add(1, 10);
            htable.Add(2, 20);
            htable.Add(3, 30);
            htable.Add("3", "Abhi");
            htable.Add(4, "Amar");
            foreach (var item in htable)
            {
                Console.WriteLine(item);
            }
            htable.Remove(2);
           
            
           Console.WriteLine("removed");
            foreach (var item in htable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(htable.ContainsKey("6"));

            foreach (var item in htable.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in htable.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count:" + htable.Count);

        }
        public void SortedListhandling()
        {
            SortedList sl=new SortedList();
            sl.Add(1, 10);
            sl.Add(2, 20);
            sl.Add(3, 30);
            sl.Add(4, "Adi");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }


        }
    }
}
