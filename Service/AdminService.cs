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

        
        public AdminDto CreateAdmin(AdminDtoForCreate admin)
        {
            var adminForCreate = _mapper.Map<Admin>(admin);
            
            _repository.Admin.CreateAdmin(adminForCreate);
            _repository.Save();
 
            var returnedOBJ = _mapper.Map<AdminDto>(adminForCreate);

            return returnedOBJ;
        }

        public AdminDto DeleteAdmin(int id)
        {
            var admin = _repository.Admin.GetAdmin(id);
            if (admin is null) throw  new AdminNotFoundException(id);
            
            _repository.Admin.DeleteAdmin(admin);
            _repository.Save();

            var returnOBJ = _mapper.Map<AdminDto>(admin); 
            return returnOBJ;
        }

        public AdminDto GetAdmin(int id)
        {
            var admin = _repository.Admin.GetAdmin(id);
            
            if (admin is null) throw new AdminNotFoundException(id);

            var adminDto = _mapper.Map<AdminDto>(admin);
            return adminDto;
        }

        public IEnumerable<AdminDto> GetAllAdmins()
        {
                var admins = _repository.Admin.GetAllAdmins();

                var adminDto = _mapper.Map<IEnumerable< AdminDto>>(admins);
                return adminDto;
        }
    }
}
