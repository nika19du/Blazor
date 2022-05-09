using IMS.CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMS.UseCases.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}
