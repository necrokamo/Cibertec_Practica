using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CommonHelpers
    {
        private static string GetHtmlForDate(DateTime? dFecha)
        {
            return dFecha == null ? $"<td>{DateTime.Now.ToString("dd/mm/yyyy")}</td>" : $"<td>{dFecha.Value.ToString("dd/MM/yyyy")}</td>";
         }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? Ndate)
        {
            return new HtmlString(GetHtmlForDate(Ndate));
        }

    }
}