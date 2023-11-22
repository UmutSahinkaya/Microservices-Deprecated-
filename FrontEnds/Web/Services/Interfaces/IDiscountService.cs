using System.Threading.Tasks;
using Web.Models.Discounts;

namespace Web.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<DiscountViewModel> GetDiscount(string discountCode);
    }
}
