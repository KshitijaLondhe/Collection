using System;
using System.Collections.Generic;


namespace Collection
{
    public class Employee1
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }



        public override string ToString()
        {
            return $"Id:{id} Name:{name} Salary:{salary}";
        }
    }
}
