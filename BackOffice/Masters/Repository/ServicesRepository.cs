using BackOffice.Masters.IRepository;
using BackOffice.Masters.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BackOffice.Masters.Repository
{
    public class ServicesRepository:IServices
    {
        private readonly IConfiguration _configuration;

        public ServicesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Services>> GetAllServicesAsync()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var StoredProcedure = "GetAllServices";
            var res = await connection.QueryAsync<Services>(StoredProcedure);
            return res;
        }

        public async Task<Services> GetServicesByIdAsync(int id)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            return await connection.QueryFirstOrDefaultAsync<Services>("GetServicesById",
                new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
        }
        public async Task<int> AddServicesAsync(Services services)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            return await connection.ExecuteAsync(
            "CreateServices",
            new
            {
                services.Name,
                services.Status,
                services.CreatedDate,
                services.CreatedBy,
                services.UpdateDate,
                services.UpdatedBy
            },
                commandType: System.Data.CommandType.StoredProcedure);
        }
        public async Task<int> UpdateServicesAsync(Services services)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            return await connection.ExecuteAsync(
                "UpdateServices",
                new
                {
                    services.Name,
                    services.Status,
                    services.UpdateDate,
                    services.UpdatedBy
                },
                commandType: System.Data.CommandType.StoredProcedure);
        }
        public async Task<int> DeleteServicesAsync(int id)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            return await connection.ExecuteAsync(
                "DeleteServices",
                new { Id = id },
                commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
