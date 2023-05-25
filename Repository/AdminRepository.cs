using Contracts;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository
    {
        public AdminRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAdmin(Admin admin) => Create(admin);

        public void DeleteAdmin(Admin admin)=>Delete(admin);

        public async Task<Admin> GetAdmin(int id ) =>
            await FindByCondition(c => c.Id.Equals(id)).SingleOrDefaultAsync();

        public async Task<IEnumerable<Admin>>  GetAllAdmins()=> 
             await  FindAll()
            .OrderBy(c=>c.Name)
            .ToListAsync();

    }
}
