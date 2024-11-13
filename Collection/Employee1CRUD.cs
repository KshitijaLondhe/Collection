using System;
using System.Collections.Generic;

namespace Collection
{
    public class Employee1CRUD
    {
        List<Employee1> Employees;
        public Employee1CRUD()
        {
            Employees = new List<Employee1>();
           
        }

        public void AddEmployee(Employee1 emp)
        {
            Employees.Add(emp);
        }
        public void ModifyEmployee(Employee1 emp)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].id == emp.id)
                {
                    Employees[i].name = emp.name;
                    Employees[i].salary = emp.salary;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].id == id)
                {
                    Employees.Remove(Employees[i]);
                    break;
                }
            }
        }
        public List<Employee1> EmployeeList()
        {
            return Employees;
        }

        public Employee1 GetEmployeeById(int id)
        {
            Employee1 e = new Employee1();
            foreach (var item in Employees)
            {
                if (item.id == id)
                {
                    e.id = item.id;
                    e.name = item.name;
                    e.salary = item.salary;
                    break;
                }
            }
            return e;
        }

    }
}

