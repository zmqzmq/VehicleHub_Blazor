using BlazorCRUD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Contracts
{
    public interface IManufacturersManager
    {
        Task<int> Create(Manufacturer manufacturer);
        Task<int> Delete(int Id);
        Task<int> Update(Manufacturer manufacturer);
        Task<Manufacturer> GetById(int Id);
        Task<List<Manufacturer>> ListAll();
    }
}

