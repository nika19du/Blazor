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
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IIventoryRepository inventoryRepository;

        public AddInventoryUseCase(IIventoryRepository iventoryRepository)
        {
            this.inventoryRepository = iventoryRepository;
        }

        public async Task ExecuteAsync(Inventory invetory)
        {
            await this.inventoryRepository.AddInventoryAsync(invetory);
        }
    }
}
