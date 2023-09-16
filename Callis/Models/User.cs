using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Callis.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress{ get; set; }
        
        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Name { get; set; }

        
        public int TaskNo { get; set; }

        public virtual int? AccountTypeId { get; set; }
        
        [ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }

    }
}
