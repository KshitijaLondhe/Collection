using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;


namespace Collection
{
    public class TestProduct1
    {
       /* static void Main(string[] args)
        {
            Product1CRUD crud = new Product1CRUD();
            try
            {
                int a = 1;
                do
                {

                    Console.WriteLine("1.Product List");
                    Console.WriteLine("2.Add Product");
                    Console.WriteLine("3.Modify Product");
                    Console.WriteLine("4.Delete Product");
                    Console.WriteLine("5.Get Product By Id");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Product1> products = crud.ProductList();
                            Console.WriteLine("Id" + " " + "Name" + " " + "Price");
                            foreach (var item in products)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 2:
                            Product1 p1 = new Product1();
                            Console.WriteLine("Enter Id");
                            p1.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            p1.name = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            p1.price = Convert.ToInt32(Console.ReadLine());
                            crud.AddProduct(p1);
                            Console.WriteLine("Added the product");
                            break;
                        case 3:
                            Product1 p2 = new Product1();
                            Console.WriteLine("Enter existing Id");
                            p2.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name");
                            p2.name = Console.ReadLine();
                            Console.WriteLine("Enter new Price");
                            p2.price = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyProduct(p2);
                            Console.WriteLine("updated the product");
                            break;
                        case 4:
                            Console.WriteLine("Enter existing Id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteProduct(id);
                            Console.WriteLine("Deleted the product");
                            break;
                        case 5:
                            Console.WriteLine("Enter existing Id");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Product1 p = crud.GetProductById(id2);
                            Console.WriteLine(p);
                            break;
                    }
                    Console.WriteLine("Press 1 for continue or 0 to exit");
                    a = Convert.ToInt32(Console.ReadLine());
                }

                while (a == 1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}
