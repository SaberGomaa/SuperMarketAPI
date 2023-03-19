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
        IEnumerable<Admin> GetAllAdmins();
        Admin GetAdmin(int id );
        void CreateAdmin(Admin admin );
    }
}
