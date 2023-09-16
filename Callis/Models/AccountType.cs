using System.ComponentModel.DataAnnotations;

namespace Callis.Models
{
    public class AccountType
    {
        [Key]
        public int id { get; set; }

        public string acctype { get; set; }

    }
}
