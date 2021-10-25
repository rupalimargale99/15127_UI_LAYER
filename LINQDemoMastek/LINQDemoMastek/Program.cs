using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemoMastek
{
    class Program
    {
        static bool IsEvenNumber(int num)
        {
            if(num%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            #region Array

            //int[] numbers = { 44, 566, 3432, 67, 4545, 788, 767, 989, 3434, 565, 3, 7676 };

            ////print even numbers
            //int[] evendata = (from n in numbers where n % 2 == 0 select n).ToArray();

            ////method

            //evendata = numbers.Where(n => n % 2 == 0).ToArray();

            ////evendata = numbers.Where(IsEvenNumber).ToArray();

            //foreach(int item in numbers)
            //{
            //    if(IsEvenNumber(item))
            //    {

            //    }
            //}

            //for(int i=0;i<evendata.Length;i++)
            //{
            //    Console.WriteLine(evendata[i]);
            //}

            #endregion

            #region List
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpNo = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { EmpNo = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { EmpNo = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { EmpNo = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { EmpNo = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { EmpNo = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });

            #endregion


            //1 simple query

            IEnumerable<Employee> query1 = from e in empList select e;

            //---------------------------------
            //2 filter
            //list emps working in sales dept

            IEnumerable<Employee> query2 = from e in empList where e.Dept=="sales" select e;
            query2 = empList.Where(e => e.Dept=="sales");

            //3     list all emps who are earning more then 25000
            IEnumerable<Employee> query3 = from e in empList
                                           where e.Salary > 25000
                                           select e;

            query3 = empList.Where(e => e.Salary > 25000);




            //4     list all emps who are staying in mumbai and working for hr dept
            IEnumerable<Employee> query4 = from e in empList
                                           where e.Address == "mumbai" && e.Dept == "hr"
                                           select e;
            query4 = empList.Where(e => e.Address == "mumbai" && e.Dept == "hr");


            //5     list all emps whose name begins with p
            IEnumerable<Employee> query5 = from e in empList where e.EmpName.StartsWith('p') select e;
            //defered  Execution
            //query5 = empList.Where(e => e.EmpName.StartsWith("p"));

            //immediate Execution
            query5 = empList.Where(e => e.EmpName.StartsWith("p")).ToList();

            empList.Add(new Employee() { EmpNo = 201, EmpName = "peter", Address = "pune", Dept = "hr", Salary = 25000 });

            Console.WriteLine("---------------Linq query output---------------");
            //defered Execution
            //foreach (Employee item in query5)
            //{
            //    Console.WriteLine(item);
            //}

            empList.Add(new Employee() { EmpNo = 301, EmpName = "peter1", Address = "pune", Dept = "hr", Salary = 25000 });

            Console.WriteLine("---------------Linq query output---------------");
            //defered Execution
            //foreach (Employee item in query5)
            //{
            //    Console.WriteLine(item);
            //}

            //6 list emp whose empno is 102

            //Employee emp = (from e in empList where e.EmpNo == 102 select e).SingleOrDefault();

            //Employee emp = (from e in empList where e.Address=="mumbai" select e).FirstOrDefault();

            //emp = empList.Where(e => e.EmpNo == 102).FirstOrDefault();

            //emp = empList.FirstOrDefault(e => e.EmpNo == 102);

            //Console.WriteLine("Employee :" + emp);

            //specific column selection

            IEnumerable<Employee> query7 = from e in empList select e;
            //known type
            //Employee emp = new Employee();
            //var emp1 = new { emp.EmpName, emp.Dept, emp.Salary };

            var query8 = from e in empList select new { e.EmpName, Department=e.Dept, e.Salary };
            //query8 = empList.Select(e => new { e.EmpName, e.Dept, e.Salary });

            //method syntax
            query8 = empList.Select(e => new { e.EmpName, Department = e.Dept, e.Salary });
            foreach (var item in query8)
            {
                Console.WriteLine(item.EmpName + "  " + item.Department + "  " + item.Salary);
            }

            //list all emp name and salary who are earning between 20000 t0 30000
            var query9 = from e in empList where e.Salary >= 20000 && e.Salary <= 30000 select new { e.EmpName, e.Salary };
            query9 = empList.Where(e => e.Salary >= 20000 && e.Salary <= 30000).Select(e => new { e.EmpName, e.Salary });

            foreach (var item in query9)
            {
                Console.WriteLine(item.GetType().Name);
            }
        }
    }
}
