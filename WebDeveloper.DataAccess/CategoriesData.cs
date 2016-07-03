using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CategoriesData: DataBaseAcess<Categories>
    {
        public Categories GetCategoryByID(int Id)
        {
            using (var dbContext=new WebContextDataBase())
            {
                return GetList().Where(c => c.CategoryID == Id).FirstOrDefault();
            }
        }
    }
}
