using System.Threading.Tasks;
using Dapper;
using Discount.Entities;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Discount.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly IConfiguration _configuration;
        private string connectionString;

        public DiscountRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetValue<string>("DatabaseSettings:ConnectionString");
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var afftected = await connection.ExecuteAsync(
                    "INSERT INTO Coupon (ProductName, Description, Amount) VALUES (@ProductName, @Description, @Amount)", 
                    new {ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount});

                if (afftected == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var affected = await connection.ExecuteAsync(
                    "DELETE FROM Coupon WHERE ProductName = @ProductName", 
                    new {ProductName = productName}
                );

                if (affected == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>(
                    "SELECT * FROM Coupon WHERE ProductName = @ProductName", new {
                        ProductName = productName
                    }
                );

                if (coupon == null)
                {
                    coupon = new Coupon {ProductName = productName, Amount = 0, Description = "NO"};
                }

                return coupon;
            }
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var afftected = await connection.ExecuteAsync(
                    "UPDATE Coupon SET ProductName = @ProductName, Description = @Description, Amount = @Amount WHERE Id = @Id", 
                    new {ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount, Id = coupon.Id});

                if (afftected == 0)
                {
                    return false;
                }

                return true;
            }
        }
    }
}