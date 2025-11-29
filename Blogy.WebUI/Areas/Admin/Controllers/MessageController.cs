using Blogy.Business.Services.MessageServices;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Admin)]
    public class MessageController(IMessageService _messageService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _messageService.GetAllAsync();
            return View(values);
        }

        // Mesajı Silme
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _messageService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        
        [HttpGet]
        public async Task<IActionResult> MessageDetails(int id)
        {
            var value = await _messageService.GetByIdAsync(id);

            
            if (value.IsRead == false)
            {
                value.IsRead = true;
                await _messageService.UpdateAsync(value);
            }

            return View(value);
        }
    }
}
