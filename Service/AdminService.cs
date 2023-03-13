using AutoMapper;
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
        private readonly IMapper _mapper;
        public AdminService(ILoggerManager logger, IRepositoryManager repository , IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        public AdminDto GetAdmin(int id)
        {
            try
            {
                var admin = _repository.Admin.GetAdmin(id);

                var adminDto = _mapper.Map<AdminDto>(admin);

                return adminDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in {nameof(GetAdmin)} service method {ex}");
                throw;
            }
        }

        public IEnumerable<AdminDto> GetAllAdmins()
        {
            try
            {
                var admins = _repository.Admin.GetAllAdmins();

                var adminDto = _mapper.Map<IEnumerable< AdminDto>>(admins);

                return adminDto;

            }catch(Exception ex)
            {
                _logger.LogError($"Error in {nameof(GetAllAdmins)} service method {ex}");
                throw;
            }
        }
    }
}
