using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record AdminDto(int Id , string Name , string Email , string Password , string Address , string Img , string Phone );
    public record AdminDtoForCreate(string Name , string Email , string Password , string Address , string Img , string Phone );


}
