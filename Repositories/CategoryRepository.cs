using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        public void DeleteCategory(Category category) => CategoryDAO.DeleteCategory(category);

        public List<Category> GetCategories() => CategoryDAO.GetCategories();

        public Category GetCategory(int id) => CategoryDAO.FindCategory(id);

        public List<Category> GetCategorys() => CategoryDAO.GetCategorys();

        public void SaveCategory(Category category) => CategoryDAO.SaveCategory(category);

        public void UpdateCategory(Category category) => CategoryDAO.UpdateCategory(category);
    }
}
