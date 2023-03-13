using Contracts;
using ECommerce.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class AdminIService :IAdminService
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public AdminIService(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public Admin GetAdmin(int id, bool trackChanges)
        {
            try
            {
                Admin admin = _repository.Admin.GetAdmin(id, trackChanges);
                return admin;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in {nameof(GetAdmin)} service method {ex}");
                throw;
            }
        }

        public IEnumerable<Admin> GetAllAdmins(bool trackChanges)
        {
            try
            {
                var admins = _repository.Admin.GetAllAdmins(trackChanges).ToList();
                return admins;
            }catch(Exception ex)
            {
                _logger.LogError($"Error in {nameof(GetAllAdmins)} service method {ex}");
                throw;
            }
        }
    }
}
