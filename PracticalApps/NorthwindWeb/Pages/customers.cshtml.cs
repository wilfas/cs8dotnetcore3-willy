using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Packt.Shared;

namespace NorthwindWeb.Pages
{
    public class CustomersModel : PageModel
    {
        private Northwind db;

        public CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public ILookup<string, Customer> Customers { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Customers";

            Customers = db.Customers
                .OrderBy(customer => customer.Country)
                .ThenBy(customer => customer.CompanyName)
                .ToLookup(customer => customer.Country);
        }
    }
}