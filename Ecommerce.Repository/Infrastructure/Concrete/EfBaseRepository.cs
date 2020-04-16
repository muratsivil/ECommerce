using Ecommerce.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Infrastructure.Concrete
{
    public class EfBaseRepository
    {
        public ProjectContext db;

        public EfBaseRepository()
        {
            db = new ProjectContext();
        }
    }
}
