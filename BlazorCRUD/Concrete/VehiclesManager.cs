using BlazorCRUD.Contracts;
using BlazorCRUD.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorCRUD.Concrete
{
    public class VehiclesManager : IVehiclesManager
    {
        private readonly IDapperManager _dapperManager;
        public VehiclesManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public Task<int> Create(Vehicle vehicle)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("OwnerName", vehicle.OwnerName, DbType.String);
            dbPara.Add("ManufacturerId", vehicle.ManufacturerId, DbType.Int32);
            dbPara.Add("YearOfManufactue", vehicle.YearOfManufactue, DbType.Int32);
            dbPara.Add("WeightInKilo", vehicle.WeightInKilo, DbType.Decimal);
            var vehicleId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_vehicle]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return vehicleId;
        }

        public Task<Vehicle> GetById(int id)
        {
            var vehicle = Task.FromResult(_dapperManager.Get<Vehicle>($"select * from [Vehicles] where ID = {id}", null,
                    commandType: CommandType.Text));
            return vehicle;
        }

        public Task<int> Delete(int id)
        {
            var deleteVehicle = Task.FromResult(_dapperManager.Execute($"Delete [Vehicles] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteVehicle;
        }

        public Task<List<Vehicle>> ListAll()
        {
            var vehicles = Task.FromResult(_dapperManager.GetAll<Vehicle>("select * from [Vehicles]", null, commandType: CommandType.Text));
            return vehicles;

        }

        public Task<int> Update(Vehicle vehicle)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", vehicle.ID);
            dbPara.Add("OwnerName", vehicle.OwnerName, DbType.String);
            dbPara.Add("ManufacturerId", vehicle.ManufacturerId, DbType.Int32);
            dbPara.Add("YearOfManufactue", vehicle.YearOfManufactue, DbType.Int32);
            dbPara.Add("WeightInKilo", vehicle.WeightInKilo, DbType.Decimal);

            var updateCategory = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_vehicle]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateCategory;
        }
    }
}


