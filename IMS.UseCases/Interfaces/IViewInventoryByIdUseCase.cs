using IMS.CoreBusiness;
using System.Threading.Tasks;

namespace IMS.UseCases.Interfaces
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int inventoryId);
    }
}