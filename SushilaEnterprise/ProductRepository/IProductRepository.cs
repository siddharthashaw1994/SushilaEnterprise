using SushilaEnterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushilaEnterprise.ProductRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
    }
}
