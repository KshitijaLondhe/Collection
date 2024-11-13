using System;
using System.Collections.Generic;


namespace Collection
{
    public class Student1
    {
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }



        public override string ToString()
        {
            return $"Id:{id} Name:{name} Marks:{marks}";
        }
    }
}
