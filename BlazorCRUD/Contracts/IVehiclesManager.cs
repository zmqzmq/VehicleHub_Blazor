using BlazorCRUD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Contracts
{
    public interface IVehiclesManager
    {
        Task<int> Create(Vehicle vehicle);
        Task<int> Delete(int Id);
        Task<int> Update(Vehicle vehicle);
        Task<Vehicle> GetById(int Id);
        Task<List<Vehicle>> ListAll();
    }
}
