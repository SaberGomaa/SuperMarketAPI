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
        IEnumerable<AdminDto> GetAllAdmins();
        AdminDto GetAdmin(int id);
        AdminDto CreateAdmin(AdminDtoForCreate admin);

        AdminDto DeleteAdmin(int id);
    }
}
