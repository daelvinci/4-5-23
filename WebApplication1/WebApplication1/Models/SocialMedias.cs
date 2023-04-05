using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class SocialMedias
    {
        public int Id { get; set; }
        
        public string Url { get; set; }
        public string Icon { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
