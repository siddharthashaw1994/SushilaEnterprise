using SushilaEnterprise.Models;
using SushilaEnterprise.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SushilaEnterprise.Controllers
{
    public class ProductController:ApiController
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Method Get all product details
        /// </summary>
        /// <returns>List of Product</returns>
        public IHttpActionResult GetAllProduct()
        {
            var product = _productRepository.GetAllProduct();
            return Ok(product);
        }

        /// <summary>
        /// Method to Get product by productId
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Product details</returns>
        public IHttpActionResult GetProductById(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            return Ok(product);
        }

        /// <summary>
        /// Method to add product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Product details</returns>
        public IHttpActionResult AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return Ok(product);
        }

        /// <summary>
        /// Method to update product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Updated Product details</returns>
        public IHttpActionResult UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
            return Ok(product);
        }

        /// <summary>
        /// Method to delete Product by its Id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IHttpActionResult DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
            return Ok();
        }

    }
}