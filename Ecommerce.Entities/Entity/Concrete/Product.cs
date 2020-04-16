using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Entity.Concrete
{
    public class Product : BaseEntity
    {
        [Required]
        [MinLength(3, ErrorMessage = "MIN LENGHT IS 3")]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        public decimal UnitInStock { get; set; }
        public short UnitPrice { get; set; }
        public string ImageURL { get; set; }

        public virtual ICollection<Order_Detail> Order_Detail { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
