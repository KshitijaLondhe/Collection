using System;
using System.Collections;


namespace Collection
{
    public class Product:IComparable
    {
        private string name;
        private double price;
        public Product(string name,double price)
        {
            this.name = name;
            this.price = price;
        }
        public double Price
        {
            get { return price; }
        }
        public string Name
        {
            get { return name; }
        }

        public int CompareTo(object obj)
        {
            Product p1 = (Product)obj;
            if (this.price > p1.price)
            {
                return 1;
            }
            else if (this.price < p1.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"Name :{name} Price:{price}";
        }
    }
    public class Shop : IEnumerable
    {
        Product[] product;
        public Shop()
        {
            product = new Product[3];
            product[0] = new Product("Pen",100);
            product[1] = new Product("Rubber",50);
            product[2] = new Product("Pencil",200);
        }

        public IEnumerator GetEnumerator()
        {
            return product.GetEnumerator();
        }
    }

    public class Checkprice : IComparer
    {
        public int Compare(object x, object y)
        {
            Product p1 = (Product)x;
            Product p2 = (Product)y;
            if (p1.Price > p2.Price)
            {
                return 1;
            }
            else if (p1.Price < p2.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
