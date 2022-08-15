using Microsoft.AspNetCore.Identity;

namespace MyBlogWebSite.Models
{
    public class ApplicationUser :IdentityUser
    {
        public virtual List<Comment>? Comments { get; set; }
    }
}
