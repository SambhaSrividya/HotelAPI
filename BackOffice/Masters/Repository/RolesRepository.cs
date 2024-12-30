using BackOffice.Masters.IRepository;
using BackOffice.Masters.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Serilog;

namespace BackOffice.Masters.Repository
{
    public class RolesRepository : IRoles
    {
        private readonly IConfiguration _configuration;

        public RolesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<CompanyResponse> GetAllRolesAsync()
        {
            var response=new CompanyResponse();
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var StoredProcedure = "GetAllRoles";
                var res = await connection.QueryAsync<Roles>(StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                response.Error = new Error
                {
                    ErrorCode = 500,
                    ErrorDescription = ex.Message
                };
                Log.Error("{@Error}", response.Error);
                return response;
            }
        }

        public async Task<CompanyResponse> GetRolesByIdAsync(int id)
        {
            var response=new CompanyResponse();
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var res = await connection.QueryFirstOrDefaultAsync<Roles>("GetRolesById",
                    new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                response.Error = new Error
                {
                    ErrorCode = 500,
                    ErrorDescription = ex.Message
                };
                Log.Error("{@Error}", response.Error);
                return response;
            }
        }
        public async Task<CompanyResponse> AddRolesAsync(Roles roles)
        {
            var response=new CompanyResponse();
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var res = await connection.ExecuteAsync(
                "CreateRoles",
                new
                {
                    roles.Name,
                    roles.Description,
                    roles.CreatedDate,
                    roles.CreatedBy,
                    roles.UpdateDate,
                    roles.UpdatedBy
                },
                    commandType: System.Data.CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                response.Error = new Error
                {
                    ErrorCode = 500,
                    ErrorDescription = ex.Message
                };
                Log.Error("{@Error}", response.Error);
                return response;
            }
        }
        public async Task<CompanyResponse> UpdateRolesAsync(Roles roles)
        {
            var response = new CompanyResponse();
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var res = await connection.ExecuteAsync(
                    "UpdateRoles",
                    new
                    {
                        roles.Name,
                        roles.Description,
                        roles.UpdateDate,
                        roles.UpdatedBy
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                response.Error = new Error
                {
                    ErrorCode = 500,
                    ErrorDescription = ex.Message
                };
                Log.Error("{@Error}", response.Error);
                return response;
            }
        }
        public async Task<CompanyResponse> DeleteRolesAsync(int id)
        {
            var response=new CompanyResponse();
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var res = await connection.ExecuteAsync(
                    "DeleteRoles",
                    new { Id = id },
                    commandType: System.Data.CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                response.Error = new Error
                {
                    ErrorCode = 500,
                    ErrorDescription = ex.Message
                };
                Log.Error("{@Error}", response.Error);
                return response;
            }
        }
    }
}
