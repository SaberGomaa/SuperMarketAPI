using Contracts;
using Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class AdminService :IAdminService
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public AdminService(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public AdminDto GetAdmin(int id, bool trackChanges)
        {
            try
            {
                var admin = _repository.Admin.GetAdmin(id, trackChanges);

                var adminDto = new AdminDto(admin.Id, admin.Name, admin.Email, admin.Password, admin.Address, admin.Img, admin.Phone);

                return adminDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in {nameof(GetAdmin)} service method {ex}");
                throw;
            }
        }

        public IEnumerable<AdminDto> GetAllAdmins(bool trackChanges)
        {
            try
            {
                var admins = _repository.Admin.GetAllAdmins(trackChanges);

                var adminDto = admins.Select(c=> new AdminDto (c.Id, c.Name , c.Address , c.Password , c.Phone , c.Email , c.Img));

                return adminDto;
            }catch(Exception ex)
            {
                _logger.LogError($"Error in {nameof(GetAllAdmins)} service method {ex}");
                throw;
            }
        }
    }
}
