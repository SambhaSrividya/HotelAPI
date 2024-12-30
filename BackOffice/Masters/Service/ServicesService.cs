using BackOffice.Masters.IRepository;
using BackOffice.Masters.IService;
using BackOffice.Masters.Models;
using Serilog;

namespace BackOffice.Masters.Service
{
    public class ServicesService:IServicesService
    {
        private readonly IServices _repository;
        public ServicesService(IServices repository)
        {
            _repository = repository;
        }
        public async Task<CompanyResponse> AddServicesAsync(Services services)
        {
            var response=new CompanyResponse();
            try
            {
                var res= await _repository.AddServicesAsync(services);
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

        public async Task<CompanyResponse> DeleteServicesAsync(int id)
        {
            var response = new CompanyResponse();
            try
            {
                var res = await _repository.DeleteServicesAsync(id);
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

        public async Task<CompanyResponse> GetAllServicesAsync()
        {
            var response = new CompanyResponse();
            try
            {
                var res = await _repository.GetAllServicesAsync();
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

        public async Task<CompanyResponse> GetServicesByIdAsync(int id)
        {
            var response= new CompanyResponse();
            try
            {
                var res= await _repository.GetServicesByIdAsync(id);
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

        public async Task<CompanyResponse> UpdateServicesAsync(Services services)
        {
            var response = new CompanyResponse();
            try
            {
                var res= await _repository.UpdateServicesAsync(services);
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
