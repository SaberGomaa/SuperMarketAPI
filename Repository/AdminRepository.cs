using Contracts;
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

        public Admin GetAdmin(int id ) =>
            FindByCondition(c => c.Id.Equals(id)).SingleOrDefault();

        public IEnumerable<Admin> GetAllAdmins()=> 
            FindAll()
            .OrderBy(c=>c.Name)
            .ToList();

    }
}
