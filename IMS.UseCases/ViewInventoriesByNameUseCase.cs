using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        public ViewInventoriesByNameUseCase(IIventoryRepository iventotyRepository)
        {
            this.iventoryRepository = iventotyRepository;
        }

        public readonly IIventoryRepository iventoryRepository;

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await this.iventoryRepository.GetIventoriesByName(name);
        }
    }
}
