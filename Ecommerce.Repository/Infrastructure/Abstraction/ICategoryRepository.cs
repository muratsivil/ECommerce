using Ecommerce.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Repository.Infrastructure.Abstraction
{
    public interface ICategoryRepository
    {
        void CreateCategory(string categoryName, string categoryDescription);
        void UpdateCategory(Guid id, string categoryName, string categoryDescription);
        void DeleteCategory(Guid id);
        List<Category> GetActiveCategory();
        List<Category> FindByName(string categoryName);
        List<Category> GetAll();
        void TextBoxEraser(GroupBox groupBox);
    }
}
