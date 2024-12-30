﻿using BackOffice.Masters.Models;

namespace BackOffice.Masters.IService
{
    public interface IServicesService
    {
        Task<CompanyResponse> GetAllServicesAsync();
        Task<CompanyResponse> GetServicesByIdAsync(int id);
        Task<CompanyResponse> AddServicesAsync(Services services);
        Task<CompanyResponse> UpdateServicesAsync(Services services);
        Task<CompanyResponse> DeleteServicesAsync(int id);
    }
}
