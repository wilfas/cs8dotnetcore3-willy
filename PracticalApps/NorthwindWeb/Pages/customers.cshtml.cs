using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Packt.Shared;

namespace NorthwindWeb.Pages
{
    public class CustomersModel : PageModel
    {
        public IEnumerable<string> Customers { get; set; }

        private Northwind db;

        public CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Customers";

            Customers = db.Customers.Select(c => c.CompanyName);
        }
    }
}