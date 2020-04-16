using Ecommerce.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Infrastructure.Abstraction
{
    public interface IOrderDetailRepository
    {
        void DiscountPrice(float discount);
        List<Order_Detail> TakeList();

    }
}
