using AutoMapper;
using Contracts;
using Entities.Exceptions;
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

        
        public async Task<AdminDto> CreateAdmin(AdminDtoForCreate admin)
        {
            var adminForCreate = _mapper.Map<Admin>(admin);
            
            _repository.Admin.CreateAdmin(adminForCreate);
            _repository.SaveAsync();
 
            var returnedOBJ = _mapper.Map<AdminDto>(adminForCreate);

            return returnedOBJ;
        }

        public async Task<AdminDto> DeleteAdmin(int id)
        {
            var admin =  await _repository.Admin.GetAdmin(id);
            if (admin is null) throw  new AdminNotFoundException(id);
            
            _repository.Admin.DeleteAdmin(admin);
            _repository.SaveAsync();

            var returnOBJ = _mapper.Map<AdminDto>(admin); 
            return returnOBJ;
        }

        public async Task<AdminDto> GetAdmin(int id)
        {
            var admin = await _repository.Admin.GetAdmin(id);
            
            if (admin is null) throw new AdminNotFoundException(id);

            var adminDto = _mapper.Map<AdminDto>(admin);
            return adminDto;
        }

        public async Task<IEnumerable<AdminDto>> GetAllAdmins()
        {
                var admins =  await _repository.Admin.GetAllAdmins();

                var adminDto = _mapper.Map<IEnumerable< AdminDto>>(admins);
                return adminDto;
        }
    }
}
