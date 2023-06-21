using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal interface IEmp
    {
       // List<Emp> GetAllEmployee();
        void AddEmployee(Emp obj);
      
        void RemoveEmployee(int id);

    }
}
