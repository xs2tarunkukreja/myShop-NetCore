using System.Threading.Tasks;
using Basket.Entities;

namespace Basket.Repository
{
    public interface IBasketRepository {
        Task<BasketCart> GetBasket(string userName);
        Task<BasketCart> UpdateBasket(BasketCart cart);
        Task DeleteBasket(string userName);
    }
}