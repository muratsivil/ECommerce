using Ecommerce.Entities.Entity.Abstruction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Entity.Concrete
{
    public class Customer : BaseEntity 
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
