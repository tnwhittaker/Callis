using System.ComponentModel.DataAnnotations;

namespace Callis.Models
{
    public class TaskStatus
    {
  

        [Key]
        public int id { get; set; }
        public string statusname { get; set; }

    }
}
