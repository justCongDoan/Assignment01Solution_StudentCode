using BusinessObjects;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Products product);

        Products GetProduct(int id);

        void DeleteProduct(Products product);

        void UpdateProduct(Products product);

        List<Category> GetCategories();

        List<Products> GetProducts();
    }
}