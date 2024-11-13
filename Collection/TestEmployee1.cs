using System;
using System.Collections.Generic;


namespace Collection
{
    public class TestEmployee1
    {
       /* static void Main(string[] args)
        {
            Employee1CRUD crud = new Employee1CRUD();
            try
            {
                int a = 1;
                do
                {

                    Console.WriteLine("1.Employee List");
                    Console.WriteLine("2.Add Employee");
                    Console.WriteLine("3.Modify Employee");
                    Console.WriteLine("4.Delete Employee");
                    Console.WriteLine("5.Get Employee By Id");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Employee1> employees = crud.EmployeeList();
                            Console.WriteLine("Id" + " " + "Name" + " " + "Salary");
                            foreach (var item in employees)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 2:
                            Employee1 e1 = new Employee1();
                            Console.WriteLine("Enter Id");
                            e1.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            e1.name = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            e1.salary = Convert.ToInt32(Console.ReadLine());
                            crud.AddEmployee(e1);
                            Console.WriteLine("Employee Added Successfully");
                            break;
                        case 3:
                            Employee1 e2 = new Employee1();
                            Console.WriteLine("Enter existing Id");
                            e2.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name");
                            e2.name = Console.ReadLine();
                            Console.WriteLine("Enter new Salary");
                            e2.salary = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyEmployee(e2);
                            Console.WriteLine("Employee Details Updated");
                            break;
                        case 4:
                            Console.WriteLine("Enter existing Id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteEmployee(id);
                            Console.WriteLine("Deleted the product");
                            break;
                        case 5:
                            Console.WriteLine("Enter existing Id");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Employee1 e = crud.GetEmployeeById(id2);
                            Console.WriteLine(e);
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
