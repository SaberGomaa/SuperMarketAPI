using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContactRepository : RepositoryBase<ContactRepository>, IContactRepository
    {
        public ContactRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
