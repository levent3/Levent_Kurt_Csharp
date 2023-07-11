using Levent_Kurt_Csharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Levent_Kurt_Csharp.ViewComponents
{
    public class YanHaber:ViewComponent
    {


        public async Task<IViewComponentResult> InvokeAsync(List<Response> model)
        {

            return View(model);
        }
    }
}
