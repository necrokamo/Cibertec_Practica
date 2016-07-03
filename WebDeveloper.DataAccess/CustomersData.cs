using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CustomersData : DataBaseAcess<Customers>
    {
        public Customers GetCustomersByID(string Id)
        {
            using (var dbContext = new WebContextDataBase())
            {
                return GetList().Where(c => c.CustomerID== Id).FirstOrDefault();
            }
        }
    }
}
