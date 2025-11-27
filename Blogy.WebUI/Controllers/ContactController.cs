using Blogy.Business.DTOs.MessageDtos;
using Blogy.Business.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class ContactController(IMessageService _messageService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
        {
            if (ModelState.IsValid)
            {
                await _messageService.CreateAsync(createMessageDto);

                return RedirectToAction("Index", "Contact");
            }

            return RedirectToAction("Index", "Contact");
        }
    }
}
