using Blogy.Business.Services.CommentServices;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    public class CommentController(UserManager<AppUser> _userManager, ICommentService _commentService) : Controller
    {
        [Area("Writer")]
        [Authorize(Roles = Roles.Writer)]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = await _commentService.GetCommentsByWriterAsync(user.Id);
            return View(values);
        }
    }
}
