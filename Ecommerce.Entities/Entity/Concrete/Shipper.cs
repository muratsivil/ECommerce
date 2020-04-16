using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Entity.Concrete
{
    public class Shipper : BaseEntity
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Order> Order { get; set; }

    }
}
