using System.Threading.Tasks;
using Web.Models.Discounts;
using Web.Services.Interfaces;

namespace Web.Services
{
    public class DiscountService : IDiscountService
    {
        public Task<DiscountViewModel> GetDiscount(string discountCode)
        {
            throw new System.NotImplementedException();
        }
    }
}
