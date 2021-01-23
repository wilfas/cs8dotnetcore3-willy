using System.ComponentModel.DataAnnotations;

namespace Packt.Shared
{
    public class Customer
    {
        [StringLength(5)]
        public string CustomerID { get; set; }
        
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(15)]
        public string City { get; set; }
    }
}