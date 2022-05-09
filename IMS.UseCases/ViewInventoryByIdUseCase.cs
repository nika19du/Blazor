using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
    {
        private readonly IIventoryRepository inventoryRepository;
        public ViewInventoryByIdUseCase(IIventoryRepository iventoryRepository)
        {
            this.inventoryRepository = iventoryRepository;
        }
        public async Task<Inventory?> ExecuteAsync(int inventoryId)
        {
            return await this.inventoryRepository.GetInventoryById(inventoryId);
        }
    }
}
