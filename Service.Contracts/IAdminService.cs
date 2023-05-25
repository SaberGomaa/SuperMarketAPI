using Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IAdminService
    {
        Task<IEnumerable<AdminDto>> GetAllAdmins();
        Task<AdminDto> GetAdmin(int id);
        Task<AdminDto> CreateAdmin(AdminDtoForCreate admin);
        Task<AdminDto> DeleteAdmin(int id);
    }
}
