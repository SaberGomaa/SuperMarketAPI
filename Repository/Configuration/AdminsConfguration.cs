using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class AdminsConfguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {

            builder.HasData
                    (
                     
                         new Admin
                         {
                             Id = 2,
                             Address = "Egypt",
                             Email = "saber@gmail.com",
                             Img = "saber.jpg",
                             Name = "Saber Gomaa",
                             Password = "123",
                             Phone = "01095575989",
                             customer_id = null,
                         }
                    );
        }
    }
}
