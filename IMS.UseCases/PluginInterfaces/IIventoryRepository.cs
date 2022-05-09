using IMS.CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IIventoryRepository
    {
        Task<Inventory?> GetInventoryById(int inventoryId);
        Task<IEnumerable<Inventory>> GetIventoriesByName(string name);
        Task AddInventoryAsync(Inventory invetory);

        Task UpdateInventoryAsync(Inventory inventory);
    }
}
