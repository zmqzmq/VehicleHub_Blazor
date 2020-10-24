using BlazorCRUD.Contracts;
using BlazorCRUD.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Linq;

namespace BlazorCRUD.Concrete
{
    public class CategoriesManager : ICategoriesManager
    {
        private readonly IDapperManager _dapperManager;
        public CategoriesManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public Task<int> Create(Category category)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Name", category.Name, DbType.String);
            dbPara.Add("WeightMin", category.WeightMin, DbType.Int32);
            dbPara.Add("WeightMax", category.WeightMax, DbType.Int32);
            dbPara.Add("IconPath", category.IconPath, DbType.String);
            var categoryId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_category]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return categoryId;
        }

        public Task<Category> GetById(int id)
        {
            var category = Task.FromResult(_dapperManager.Get<Category>($"select * from [Categories] where ID = {id}", null,
                    commandType: CommandType.Text));
            return category;
        }

        public Task<int> Delete(int id)
        {
            var deleteCategory = Task.FromResult(_dapperManager.Execute($"Delete [Categories] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteCategory;
        }

        public Task<List<Category>> ListAll()
        {
            var categories = Task.FromResult(_dapperManager.GetAll<Category>("select * from [Categories]", null, commandType: CommandType.Text));
            return categories;

        }

        public Task<int> Update(Category category)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", category.ID);
            dbPara.Add("Name", category.Name, DbType.String);
            dbPara.Add("WeightMin", category.WeightMin, DbType.Int32);
            dbPara.Add("WeightMax", category.WeightMax, DbType.Int32);
            dbPara.Add("IconPath", category.IconPath, DbType.String);

            var updateCategory = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_category]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateCategory;
        }

        public Task<string> ValidateCategoryWeightRange(Category category, List<Category> categoryList)
        {
            //valid if no exsiting category 
            if (categoryList.Count == 0)
            {
                return Task.FromResult(string.Empty);
            }

            if (category.WeightMin > category.WeightMax)
            {
                return Task.FromResult("WeightMax should be greater than WeightMin.");
            }

            int currentMin=0, currentMax=0;
            if (category.ID > 0)
            {
                List<Category> categoryListRemoveUpdateCategory = categoryList.Where(c => c.ID != category.ID).ToList();
                currentMin = categoryListRemoveUpdateCategory.Min(c => c.WeightMin);
                currentMax = categoryListRemoveUpdateCategory.Max(c => c.WeightMax);
            }
            else
            {
                currentMin = categoryList.Min(c => c.WeightMin);
                currentMax = categoryList.Max(c => c.WeightMax);
            }
            //valid if no gaps and no cross
            if ((category.WeightMin - currentMax == 1) || (currentMin - category.WeightMax == 1))
            {
                return Task.FromResult(string.Empty);
            }

            return Task.FromResult("Weight range is invalid.");
        }
        public Task<string[]> GetIconPaths()
        {
            var filters = new String[] { ".jpg", ".jpeg", ".png", ".gif", ".tiff", ".bmp", ".svg" };
            string currentdirectory = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(string.Concat(currentdirectory, "\\wwwroot\\Image"));
            
            var files = Directory.EnumerateFiles(string.Concat(currentdirectory, "\\wwwroot\\Image"))
                .Where(fileName => filters.Any(filter => fileName.EndsWith(filter)))
                .Select(fileName => Path.GetRelativePath(string.Concat(currentdirectory, "\\wwwroot"), fileName)) // get relative path
                .Select(fileName => Path.Combine("/", fileName))          // prepend the baseUrl
                .Select(fileName => fileName.Replace("\\", "/"));

            return Task.FromResult(files.ToArray());
        }

    }
}


