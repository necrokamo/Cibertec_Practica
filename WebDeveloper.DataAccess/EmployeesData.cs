using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class EmployeesData: DataBaseAcess<Employees>
    {
        public Employees GetEmployeesByID(int Id)
        {
            using (var dbContext = new WebContextDataBase())
            {
                return GetList().Where(e => e.EmployeeID== Id).FirstOrDefault();
            }
        }
    }
}
