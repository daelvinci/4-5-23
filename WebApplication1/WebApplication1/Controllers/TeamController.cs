using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        private DataContext _context { get; set; }

        public TeamController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
            return View(_context.TeamMembers.Include(x => x.SocialMedias).ToList());
        }
    }
}
