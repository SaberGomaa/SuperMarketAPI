using Contracts;
using ECommerce.Models;
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

        public Admin GetAdmin(int id , bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefault();

        public IEnumerable<Admin> GetAllAdmins(bool trackChanges)=> 
            FindAll(trackChanges)
            .OrderBy(c=>c.Name)
            .ToList();

    }
}
