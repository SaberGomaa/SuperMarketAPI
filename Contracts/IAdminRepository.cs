using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> GetAllAdmins();
        Task<Admin> GetAdmin(int id );
        void CreateAdmin(Admin admin );
        void DeleteAdmin(Admin admin );
    }
}
