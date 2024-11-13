using System;
using System.Collections.Generic;

namespace Collection
{
    public class Product1CRUD
    {
        List<Product1> Products;
        public Product1CRUD()
        {
            Products = new List<Product1>(); 
            // list is empty initialy
        }

        public void AddProduct(Product1 prod)
        {
            Products.Add(prod);
        }
        public void ModifyProduct(Product1 prod)
        // prod obj contains new values after modifying
        {
            //1.iterate over collection
            //2.find that product object
            //3.replace the values
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].id == prod.id)
                {
                    Products[i].name = prod.name;
                    Products[i].price = prod.price;
                    break;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].id == id)
                {
                    Products.Remove(Products[i]);
                    //Products.RemoveAt(i);
                    break;
                }
            }
        }
        public List<Product1> ProductList()
        {
            return Products;
        }

        public Product1 GetProductById(int id)
        {
            Product1 p = new Product1();
            foreach (var item in Products)
            {
                if (item.id == id)
                {
                    p.id = item.id;
                    p.name = item.name;
                    p.price = item.price;
                    break;
                }
            }
            return p;
        }

    }

}
