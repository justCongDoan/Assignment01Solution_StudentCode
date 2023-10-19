using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Products product) => ProductDAO.DeleteProduct(product);

        public List<Category> GetCategories() => CategoryDAO.GetCategories();

        public Products GetProduct(int id) => ProductDAO.FindProduct(id);

        public List<Products> GetProducts() => ProductDAO.GetProducts();

        public void SaveProduct(Products product) => ProductDAO.SaveProduct(product);

        public void UpdateProduct(Products product) => ProductDAO.UpdateProduct(product);
    }
}