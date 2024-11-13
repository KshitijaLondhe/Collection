using System;
using System.Collections.Generic;



namespace Collection
{
    public class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("raj");
            set.Add("priya");
            set.Add("akshata");
            set.Add("veer");
            set.Add("ram");
            set.Remove("ram");
            Console.WriteLine(set.Contains("veer"));
            //set.Clear();
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
