using BlazorCRUD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Contracts
{
    public interface ICategoriesManager
    {
        Task<int> Create(Category category);
        Task<int> Delete(int Id);
        Task<int> Update(Category category);
        Task<Category> GetById(int Id);
        Task<List<Category>> ListAll();
        Task<string[]>  GetIconPaths();
        Task<string> ValidateCategoryWeightRange(Category category, List<Category> categoryList);
    }
}