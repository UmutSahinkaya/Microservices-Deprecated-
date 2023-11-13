using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Shared.Dtos;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbconnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbconnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var status = await _dbconnection.ExecuteAsync("delete from discount where id=@Id", new { Id = id });
            return status > 0 ? Response<NoContent>.Success(200) : Response<NoContent>.Fail("Discount not found", 404);
        }

        public async Task<Response<List<Models.Discount>>> GetAllAsync()
        {
            var discounts = await _dbconnection.QueryAsync<Models.Discount>("Select * from discount");
            return Response<List<Models.Discount>>.Success(discounts.ToList(), 200);
        }

        public async Task<Response<Models.Discount>> GetByCodeAndUserIdAsync(string code, string userId)
        {
            var discounts = await _dbconnection.QueryAsync<Models.Discount>("select * from discount Where userid=@UserId and code=@Code", new
            {
                UserId = userId,
                Code = code
            });
            var hasDiscount = discounts.FirstOrDefault();
            if (hasDiscount == null)
                return Response<Models.Discount>.Fail("Discount not found", 404);
            return Response<Models.Discount>.Success(hasDiscount, 200);
        }

        public async Task<Response<Models.Discount>> GetByIdAsync(int id)
        {
            var discount = (await _dbconnection.QueryAsync<Models.Discount>("select * from discount where id=@Id", new { Id = id })).SingleOrDefault();
            if (discount == null)
                return Response<Models.Discount>.Fail("Discount not found",404);
            return Response<Models.Discount>.Success(discount, 200);
        }

        public async Task<Response<NoContent>> SaveAsync(Models.Discount discount)
        {
            //Verileri anonim bir objeden okumak yerine direk discount veilebilir iki farklı yöntemi de seçebilirsiniz.
            var saveStatus = await _dbconnection.ExecuteAsync("INSERT INTO discount (userid,rate,code) VALUES (@UserId,@Rate,@Code)", discount);
            if (saveStatus > 0)
                return Response<NoContent>.Success(204);
            return Response<NoContent>.Fail("an error occurred while adding.", 500);

        }

        public async Task<Response<NoContent>> UpdateAsync(Models.Discount discount)
        {
            //var status = await _dbconnection.ExecuteAsync("Update discount set userid=@UserId,code=@Code,rate=@Rate where id=@Id", discount); veya
            var status = await _dbconnection.ExecuteAsync("Update discount set userid=@UserId,code=@Code,rate=@Rate where id=@Id", new
            {
                Id= discount.Id,
                UserId= discount.UserId,
                Code= discount.Code,
                Rate= discount.Rate
            });
            if (status > 0)
                return Response<NoContent>.Success(204);
            return Response<NoContent>.Fail("Discount not found", 404);
        }
    }
}
