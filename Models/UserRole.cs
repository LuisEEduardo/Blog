using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("[UserRole]")]
    public class UserRole
    {
        [Key]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Key]
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
    }
}