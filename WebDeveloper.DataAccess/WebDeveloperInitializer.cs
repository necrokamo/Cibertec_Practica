using System.Data.Entity;
using WebDeveloper.Model;
using System.Collections.Generic;
using System.Linq;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDataBase>
    {
        protected override void Seed(WebContextDataBase context)
        {
            var customer = new List<Customers>
            {
                new Customers {CustomerID="1",CompanyName="Lely",ContactName="Walter Camones",ContactTitle="Developer",Address="Str. Benavides 343",City="Lima",Region="Lima",PostalCode="",Country="Peru",Phone="4562000",Fax="" }
            };
            customer.ForEach(C => context.Customer.Add(C));
            context.SaveChanges();
        }
    }
}