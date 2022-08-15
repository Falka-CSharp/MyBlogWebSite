using System.ComponentModel.DataAnnotations;
namespace MyBlogWebSite.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Заголовок публікації")]
        public string? Title { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Зміст публікації")]
        public string? Description { get; set; }

        [Required]
        [MaxLength(1024)]
        [Display(Name = "Контент публікації")]
        public string? Content { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата публікації")]
        public DateTime PublishedDate  { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Час публікації")]
        public DateTime PublishedTime { get; set; }

        [MaxLength(100)]
        [Display(Name = "Зображення")]
        public string? imagePath { get; set; }

        public int CategoryId { get;set; }
        public virtual Category? Category { get; set; }

        public virtual List<Comment>? Comments { get; set; }
    }
}
