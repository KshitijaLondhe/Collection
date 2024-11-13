using System;
using System.Collections.Generic;


namespace Collection
{
    public class Product1
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }


        
        public override string ToString()
        {
            return $"Id:{id} Name:{name} Price:{price}";
        }
    }
}
