using Ecommerce.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Repository.Infrastructure.Abstraction
{
    interface ISuppliersRepository
    {
        void CreateSupplier(string companyName, string contactName, string contactTitle, string address);
        void UpdateSupplier(Guid id, string companyName, string contactName, string contactTitle, string address);
        void DeleteSupplier(Guid id);
        List<Supplier> GetActiveCategory();
        List<Supplier> FindByName(string companyName);
        List<Supplier> GetAll();
        void TextBoxEraser(GroupBox groupBox);

    }
}
