using BackOffice.Masters.IRepository;
using BackOffice.Masters.IService;
using BackOffice.Masters.Models;
using Serilog;

namespace BackOffice.Masters.Service
{
    public class RolesService : IRolesService
    {
        private readonly IRoles _repository;
        public RolesService(IRoles repository)
        {
            _repository = repository;
        }
        public async Task<CompanyResponse> AddRolesAsync(Roles roles)
        {
            var response=new CompanyResponse();
            try
            {
                var res = await _repository.AddRolesAsync(roles);
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
                var res = await _repository.DeleteRolesAsync(id);
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

        public async Task<CompanyResponse> GetAllRolesAsync()
        {
            var response=new CompanyResponse();
            try
            {
                var res = await _repository.GetAllRolesAsync();
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
                var res = await _repository.GetRolesByIdAsync(id);
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
            var response=new CompanyResponse();
            try
            {
                var res = await _repository.UpdateRolesAsync(roles);
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
