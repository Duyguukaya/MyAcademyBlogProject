using Blogy.Business.Services.TagServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogList
{
    public class _TagsListComponent(ITagService _tagService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tagService.GetAllAsync();
            return View(values);
        }
    }
}
