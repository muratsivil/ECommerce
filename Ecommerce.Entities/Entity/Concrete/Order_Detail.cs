using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Entity.Concrete
{
    public class Order_Detail : BaseEntity
    {
        public short UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public float Discount { get; set; }

        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
