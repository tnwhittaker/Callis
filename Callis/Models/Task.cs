using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Callis.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        
        [Required]
        public string TaskName { get; set; }
        
        public string TaskDesc { get; set; }
        
        [Required]
        public DateTime Dealine { get; set; }
        
        [Required]
        public string AssignedTo { get; set; }
        
        [Required]
        public string AssignBy { get; set; }
        
        public virtual int? TaskStatId { get; set;}

        [ForeignKey("TaskStatId")]
        public virtual Task Tasks { get; set; }

        public virtual int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }



    }
}
