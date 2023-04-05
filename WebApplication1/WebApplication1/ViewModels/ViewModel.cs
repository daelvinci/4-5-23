using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class ViewModel
    {
        public List<Service> Services { get; set; }
        public List<TeamMember > TeamMembers { get; set; }
        public List<SocialMedias> SocialMedias { get; set; }
    }
}
