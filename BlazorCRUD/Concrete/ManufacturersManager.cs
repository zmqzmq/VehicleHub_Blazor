using BlazorCRUD.Contracts;
using BlazorCRUD.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD.Concrete
{
    public class ManufacturersManager : IManufacturersManager
    {
        private readonly IDapperManager _dapperManager;

        public ManufacturersManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Manufacturer manufacturer)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Name", manufacturer.Name, DbType.String);
            var manufacturerId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_manufacturer]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return manufacturerId;
        }

        public Task<Manufacturer> GetById(int id)
        {
            var manufacturer = Task.FromResult(_dapperManager.Get<Manufacturer>($"select * from [Manufacturers] where ID = {id}", null,
                    commandType: CommandType.Text));
            return manufacturer;
        }

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [Manufacturers] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<List<Manufacturer>> ListAll()
        {
            var manufacturers = Task.FromResult(_dapperManager.GetAll<Manufacturer>("select * from [Manufacturers]", null, commandType: CommandType.Text));
            return manufacturers;

        }

        public Task<int> Update(Manufacturer manufacturer)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", manufacturer.ID);
            dbPara.Add("Name", manufacturer.Name, DbType.String);

            var updateManufacturer = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_manufacturer]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateManufacturer;
        }
    }
}

