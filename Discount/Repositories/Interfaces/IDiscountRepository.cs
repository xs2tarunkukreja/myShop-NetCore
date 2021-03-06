using System.Threading.Tasks;
using Discount.Entities;

namespace Discount.Repositories
{
    public interface IDiscountRepository    
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool>  DeleteDiscount(string productName);
    }    
}