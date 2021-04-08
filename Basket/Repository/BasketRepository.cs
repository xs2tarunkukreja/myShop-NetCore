using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

using Basket.Entities;

namespace Basket.Repository
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redis;

        public BasketRepository(IDistributedCache cache)
        {
            _redis = cache;
        }

        public async Task<BasketCart> GetBasket(string userName)
        {
            var basket = await _redis.GetStringAsync(userName);
            
            if (string.IsNullOrEmpty(basket))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<BasketCart>(basket);
        }

        public async Task<BasketCart> UpdateBasket(BasketCart cart)
        {
            await _redis.SetStringAsync(cart.UserName, JsonConvert.SerializeObject(cart));
            return await GetBasket(cart.UserName);
        }

        public async Task DeleteBasket(string userName)
        {
            await _redis.RemoveAsync(userName);
        }
    }
}