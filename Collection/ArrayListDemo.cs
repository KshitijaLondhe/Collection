using System;
using System.Collections;
/*ArrayList →  it is same as an array, as it stores data in contiguous memory location, 
but ArrayList can manage the data dynamically
Memory will grow & shrink at run time

Methods of ArrayList class - Add(),AddRange,Remove,RemoveAt,
RemoveRange, Insert, Contains, sort, Reverse

Properties
Count
Capacity
*/
namespace Collection
{
    internal class ArrayListDemo
    {
       /* static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20.05);
            list.Add("raj");
            list.Add('k');

           /* foreach(var item in list)
            {
                Console.WriteLine(item);
            }*/

           /* ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            
            //Methods
            list1.Add(40);
            list1.Insert(2, 25);
            list1.AddRange(list);
            list1.Remove(20.05);
            // first match objec in the collection will be removed

            list1.RemoveAt(6);
            // remove object based on index

            list1.RemoveRange(5,2);
            // remove multiple objects 

            list1.Sort();
            // sort the objects in asc order

            list1.Reverse();
            // list1.Clear();
            // remove all objects

            Console.WriteLine(list1.Contains(10));
            Console.WriteLine(list1.Contains(100));

            //Properties
            Console.WriteLine("Total elemetns :" + list1.Count);
            Console.WriteLine("Total capacity :" + list1.Capacity);


            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

        }*/
    }
}
