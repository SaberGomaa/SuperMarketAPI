using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record ProductDto(int id , string Name , double Price , string Img , string Color , string Size , int Quantity ,string Details, string Category);
    public record ProductDtoForCreation(string Name , double Price , string Img , string Color , string Size , int Quantity ,string Details, string Category , int AdminId);


}
