using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("[PostTag]")]
    public class PostTag
    {
        [Key]
        [ForeignKey("PostId")]
        public int PostId { get; set; }

        [Key]
        [ForeignKey("TagId")]
        public int TagId { get; set; }
    }
}