using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Entity.Concrete
{
    public class Order : BaseEntity
    {
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }

        public virtual ICollection<Order_Detail> Order_Detail { get; set; }

        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        
        public Guid ShipVia { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
