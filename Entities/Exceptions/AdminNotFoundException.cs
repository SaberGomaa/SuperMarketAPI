using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class AdminNotFoundException : NotFoundException
    {
        public AdminNotFoundException(int id) : base($"The Admin with id: {id} doesn't exist in the database.")
        { }
    }
}
