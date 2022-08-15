using System.ComponentModel.DataAnnotations;
namespace MyBlogWebSite.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        [Display(Name = "Comment text")]
        public string? Content { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Publication date")]

        public DateTime? PublishDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Publication time")]
        public DateTime? PublishTime { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
