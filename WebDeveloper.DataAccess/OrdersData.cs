using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class OrdersData:DataBaseAcess<Orders>
    {
        public Orders GetOrdersById(int Id)
        {
            using(var dbContext=new WebContextDataBase())
            {
                return GetList().Where(o => o.OrderID == Id).FirstOrDefault();
            }
        }
    }
}
