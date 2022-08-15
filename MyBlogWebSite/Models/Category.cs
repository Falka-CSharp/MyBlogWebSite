using System.ComponentModel.DataAnnotations;
namespace MyBlogWebSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Категорія")]
        public string? Name { get; set; }

        public virtual List<Post>? Posts { get; set; }

    }
}
