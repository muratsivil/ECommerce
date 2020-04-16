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

        private float _discount;
        public float Discount 
        {
            get
            {
                if (_discount > 100 || _discount <= 0)
                {
                    throw new Exception("Invalid Discount");
                }
                else
                {
                    return _discount;
                }
            }
            set { _discount = value; }
        }

        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
