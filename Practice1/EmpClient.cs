using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class EmpClient
    {
        public static List<Emp> empList = new List<Emp>();
        public static void main()
        {
            #region
            ////List<Emp> empList = new List<Emp>();
            ////empList.Add(new Emp(1, "Ram", 34.5f));
            ////empList.Add(new Emp(2, "Krutika", 30));
            ////empList.Add(new Emp(3, "Rutika", 40));
            //List<Emp> empList = Emp.GetAllEmployee();
            //foreach (Emp emp in empList) 
            //{
            //    //Console.WriteLine(emp.Eid+" "+emp.Name+" "+emp.Age);  //if not write string method then used this line
            //    Console.WriteLine(emp.ToString());
            //}
            #endregion
            #region
            //Console.WriteLine("--- Student Details -------");
            //var students = new List<Student>() {
            //    new Student(){ Id = 1, Name="Bill"},
            //    new Student(){ Id = 2, Name="Steve"},
            //    new Student(){ Id = 3, Name="Ram"},
            //    new Student(){ Id = 4, Name="Abdul"}
            //};
            //foreach (Student s in students)
            //{
            //    Console.WriteLine(s.Id + " " + s.Name);  //if not write string method then used this line
            //                                             // Console.WriteLine(emp.ToString());
            //}
            //Console.WriteLine("--- find student using name-------");
            //var studNames = from s in students
            //                where s.Name == "Bill"
            //                select s;

            //foreach (var student in studNames)
            //    Console.WriteLine(student.Id + ", " + student.Name);
            #endregion
         
            Emp obj = new Emp();

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Retrieve All Employees");
                Console.WriteLine("2. Add new Employee");
                Console.WriteLine("3. Remove an Employee");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your Choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    empList.Clear();
                    empList = Emp.GetAllEmployee();

                    foreach (var item in empList)
                    {
                        // Console.WriteLine(item.Eid+" "+item.Age+ " "+item.EName);
                        Console.WriteLine(item);
                    }
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter Empid,Empname and Age");
                    obj.Eid = Convert.ToInt32(Console.ReadLine());
                    obj.Name = Console.ReadLine();
                    obj.Age = Convert.ToInt32(Console.ReadLine());
                   obj.AddEmployee(obj);
                   
                    Console.WriteLine("New Record Added");
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Enter the ID");
                    obj.Eid = Convert.ToInt32(Console.ReadLine());
                    obj.RemoveEmployee(obj.Eid);
                    Console.WriteLine("The Record got removed");
                }
                else if (ch == 4)
                {
                    flag = false;
                }

            }
        }
    }

    
}
