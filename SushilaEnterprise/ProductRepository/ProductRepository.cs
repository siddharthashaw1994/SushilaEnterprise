using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SushilaEnterprise.Models;
using SushilaEnterprise.DataRepository;

namespace SushilaEnterprise.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataRepository<Product> _productRepository;
        public ProductRepository(IDataRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Method to add product
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
            _productRepository.SaveChanges();
        }

        /// <summary>
        /// Method to delete product
        /// </summary>
        /// <param name="productId"></param>
        public void DeleteProduct(int productId)
        {
            _productRepository.Delete(productId);
            _productRepository.SaveChanges();
        }

        /// <summary>
        /// Method to get all product details
        /// </summary>
        /// <returns>List of product</returns>
        public IEnumerable<Product> GetAllProduct()
        {
            var product = _productRepository.GetAll();
            return product;
        }

        /// <summary>
        /// Method to Get product by ProductId
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product GetProductById(int productId)
        {
            var product = _productRepository.GetById(productId);
            return product;
        }

        /// <summary>
        /// Method to update product
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.SaveChanges();
        }
    }
}