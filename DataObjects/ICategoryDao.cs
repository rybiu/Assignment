using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{

    public interface ICategoryDao
    {
        
        List<Category> GetCategories(int statusId);

        Category GetCategory(int categoryId, int statusId);

        int IsExist(string categoryName, int statusId);

    }
}
