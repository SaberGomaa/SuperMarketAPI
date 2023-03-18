using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Img { get; set; }
        public string Phone { get; set; }

        public int? customer_id { get; set; }
  
        [ForeignKey("customer_id")]
        public Customer? customer { get; set; }

    }
}
