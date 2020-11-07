using BusinessObjects;
using System.Collections.Generic;

namespace DataObjects
{

    public interface ICategoryDao
    {
        
        List<Category> GetCategories(int statusId);

        Category GetCategory(int categoryId, int statusId);

        int IsExist(string categoryName, int statusId);

    }
}
