using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlogWebSite.Models; 
namespace MyBlogWebSite.ViewModels
{
    public class PostsViewModel
    {
        public List<Post>? Posts { get; set; }
        public SelectList? Categories { get; set; }
        public PageViewModel? Paginator { get; set; }
    }
}
