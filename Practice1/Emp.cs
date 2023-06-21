using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Emp:IEmp
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        public float Age { get; set; }

        public Emp() { }
        public Emp(int eid, string name, float age)
        {
            Eid = eid;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Eid + " " + Name + " " + Age;
        }
        //static list 
        public static List<Emp> empList=new List<Emp>();
        public static List<Emp> GetAllEmployee() 
        {
            empList.Add(new Emp(1, "Ram", 34.5f));
            empList.Add(new Emp(2, "Krutika", 30));
            empList.Add(new Emp(3, "Rutika", 40));
            return empList;
        }

        public void AddEmployee(Emp obj)
        {
            empList.Add(obj);
        }

        public void RemoveEmployee(int id)
        {
            empList=GetAllEmployee();
            Emp O = empList.Where(x => x.Eid == id).FirstOrDefault();
            empList.Remove(O);
        }

    }
    //class Student
    //{
    //    public int Id { get; set;}
    //    public string Name { get; set; }
    //}
}
