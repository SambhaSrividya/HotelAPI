using BackOffice.Masters.Models;

namespace BackOffice.Masters.IRepository
{
    public interface IRoles
    {
        Task<CompanyResponse> GetAllRolesAsync();
        Task<CompanyResponse> GetRolesByIdAsync(int id);
        Task<CompanyResponse> AddRolesAsync(Roles roles);
        Task<CompanyResponse> UpdateRolesAsync(Roles roles);
        Task<CompanyResponse> DeleteRolesAsync(int id);
    }
}
