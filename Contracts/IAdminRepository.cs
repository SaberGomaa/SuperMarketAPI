﻿using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> GetAllAdmins(bool trackChanges);
        Admin GetAdmin(int id ,bool trackChanges);
    }
}
