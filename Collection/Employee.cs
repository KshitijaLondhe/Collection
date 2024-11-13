using System;
using System.Collections;
using System.Collections.Generic;



namespace Collection
{
    public class Employee:IComparable<Employee>
    {
        private int id;
        private string name;
        private double salary;
        public Employee(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
        }
        public double Salary
        {
            get { return salary; }
        }

        public int CompareTo(Employee e1)
        {
            //Employee e1 = (Employee)obj;
            if (this.salary > e1.salary)
            {
                return 1;
            }
            else if (this.salary < e1.salary)
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
            return $"Id : {id} Name :{name} Salary:{salary}";
        }
    }
    public class Company : IEnumerable
    {
        Employee[] e;
        public Company()
        {
            e = new Employee[3];
            e[0] = new Employee(101, "rahul", 15000);
            e[1] = new Employee(105, "priti", 25000);
            e[2] = new Employee(109, "kritika", 10000);
        }
        public IEnumerator GetEnumerator()
        {
            return e.GetEnumerator();

        }

        public class CheckSalary : IComparer<Employee>
        {
            public int Compare(Employee e1, Employee e2)
            {
                if (e1.Salary > e2.Salary)
                {
                    return 1;
                }
                else if (e1.Salary < e2.Salary)
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
}
