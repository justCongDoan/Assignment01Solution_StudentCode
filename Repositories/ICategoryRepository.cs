using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal interface ICategoryRepository
    {
        void SaveCategory(Category category);

        Category GetCategory(int id);

        void DeleteCategory(Category category);

        void UpdateCategory(Category category);

        List<Category> GetCategories();
    }
}
