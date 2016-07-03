using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductsData: DataBaseAcess<Products>
    {
        public Products GetProductsByID(int Id)
        {
            using(var dbContext=new WebContextDataBase())
            {
                return GetList().Where(p => p.ProductID == Id).FirstOrDefault();
            }
        }
    }
}
