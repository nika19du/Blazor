using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class IventoryRepository : IIventoryRepository
    {
        private readonly IMSContext db;
        public IventoryRepository(IMSContext context)
        {
            this.db = context;
        }

        public async Task<IEnumerable<Inventory>> GetIventoriesByName(string name)
        {
            return await this.db.Inventories.Where(x => x.InventoryName.Contains(name,
                System.StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(name)).ToListAsync();

        }
        public async Task AddInventoryAsync(Inventory inventory)
        {//to prevent different inventories from having the same name
            if (db.Inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, System.StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }
            this.db.Inventories.Add(inventory);
            await this.db.SaveChangesAsync();
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {//to prevent different inventories from having the same name
            if (db.Inventories.Any(x => x.InventoryId != inventory.InventoryId &&
            x.InventoryName.Equals(inventory.InventoryName, System.StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }
            var inv = await this.db.Inventories.FindAsync(inventory.InventoryId);
            if (inv != null)
            {
                inv.InventoryName = inventory.InventoryName;
                inv.Price = inventory.Price;
                inv.Quantity = inventory.Quantity;
                await db.SaveChangesAsync();
            }
        }

        public async Task<Inventory?> GetInventoryById(int inventoryId)
        {
            return await this.db.Inventories.FindAsync(inventoryId);
        }

    }
}
