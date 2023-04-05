using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using WebApplication1.DAL;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        private DataContext _context { get; set; }
        public object ViewModel { get; private set; }

        public TeamController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Vm = new ViewModel
            {
                TeamMembers = _context.TeamMembers.Include(x => x.SocialMedias).ToList(),
                SocialMedias= _context.SocialMedias.ToList()
            };
            return View(Vm);
        }
    }
}
