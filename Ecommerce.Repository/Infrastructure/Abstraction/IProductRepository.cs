using Ecommerce.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Infrastructure.Abstraction
{
    public interface IProductRepository
    {
        void AddProduct(Guid categoryId, Guid supplierId, string productName, string productDescription, string pictureUrl, decimal unitInStock, short unitPrice);
        void UpdateProduct(Guid id, Guid categoryId, Guid supplierId, string productName, string productDescription, string pictureUrl, decimal unitInStock, short unitPrice);
        void DeleteProduct(Guid id);
        List<Product> TakeList();
        List<Product> FindByName(string productName); 
        List<Product> GetAll();
        List<Product> GetByDateTime(DateTime addDate, DateTime endDate);
        List<Category> TakeCategoryList();
    }
}
