using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string BgImg { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public List<SocialMedias> SocialMedias{ get; set; }



    }
}
