using System.Collections;
using System.Collections.Generic;

namespace adv2
{
    internal class Program
    {
        public static int printarraylist(ArrayList arraylist) {
           int sum = 0 ;
            if (arraylist is not null)
            {
                for(int i =0; i < arraylist.Count; i++)
                {
                    sum += (int)arraylist[i];
                }
            }
            return sum;
        }

        public  static void PrintList<T>(List<T> values)
        {
            foreach(T item in values)
            {
                Console.Write(item);
            }
        }

        public static void Print(LinkedList<int> Linkedlist)
        {
            foreach (int item in Linkedlist)
            {
                Console.WriteLine( item);
            }
        } 

        public static void stackPrint(Stack <int> stack)
        {
            foreach(int item in stack)
            {
                Console.WriteLine( item );
            }
        }
        static void Main(string[] args)
        {
            #region  video 1 
            //    ArrayList list = new ArrayList();
            //    list.Add(1);
            //    //Console.WriteLine( $"{list .Count} , {list.Capacity} ");
            //    list.Add(2);
            //    list.Add(3);
            //    list.Add(4);
            //Console.WriteLine($"{list.Count} , {list.Capacity} ");
            //list.Add(5);
            //Console.WriteLine($"{list.Count} , {list.Capacity} ");
            //list.Add(4);
            //list.Add(4);
            //list.Add(4);
            //list.Add(4);
            //Console.WriteLine($"{list.Count} , {list.Capacity} ");
            //list.Add(4);

            //Console.WriteLine($"{list.Count} , {list.Capacity} ");
            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[2]);

            //list.AddRange(new[] { 10, 11, 12 });
            //printarraylist(list);
            //int index = list.BinarySearch(2, );
            //Console.WriteLine(index);

            //Employee3 e01 = new Employee3() { Id = 1, Name = "ahmed", Salary = 1200, Age = 10 };
            //Employee3 e02 = new Employee3() { Id = 2, Name = "omar", Salary = 1300, Age = 20 };
            //Employee3 e03 = new Employee3() { Id = 3, Name = "mohamed", Salary = 1400, Age = 30 };
            //Employee3 e04 = new Employee3() { Id = 4, Name = "amr", Salary = 1500, Age = 40 };
            //ArrayList list2 = new ArrayList();
            ////list2.AddRange(new Employee[] { e01, e02, e03, e04 });

            //foreach(Employee item in list2)
            //{
            //    //Console.WriteLine(item);
            //}

            //int index = list.BinarySearch(e03);
            //Console.WriteLine($" index = {index}");

            ArrayList list3 = new ArrayList();
            list3.Add(4);
            list3.Add(4);
            list3.Add(4);
            list3.Add(4);
            list3.Clear();

            bool flag = list3.Contains(20);
            Console.WriteLine(list3);

            int[] arr = new int[4];
            list3.CopyTo(arr, 3);

            foreach (int item in arr) {
                Console.WriteLine(item);
            }
            int i = list3.IndexOf(3);
            Console.WriteLine(i);
            #endregion

            #region video 2 

            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            //list.Add("hello world ");
            int sum = printarraylist(list);
            Console.WriteLine(sum);

            #endregion

            #region  video 3 
            //List<int> list4 = new List<int>(new int[] { 1, 2, 3, 4, });
            //PrintList(list4);
            //list4.Add(1);
            //#endregion

            //#region video 4
            //LinkedList<int> linkedlist = new LinkedList<int>();

            //linkedlist.AddFirst(1);
            //linkedlist.AddLast(2);
            //linkedlist.AddLast(3);
            //linkedlist.AddLast(4);

            //Print(linkedlist);
            //LinkedListNode<int> result = linkedlist.Find(1);
            //linkedlist.AddBefore(result, 4);
            //Console.WriteLine(linkedlist.First.Value);
            //Console.WriteLine(linkedlist.Last.Value);
            //linkedlist.Clear();
            //Console.WriteLine(linkedlist.First.Next.Value);
            #endregion

            #region video 4 
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Pop();
            //stack.TryPeek(out int top  );
            //stackPrint(stack);
            #endregion
        }
    } 
}

