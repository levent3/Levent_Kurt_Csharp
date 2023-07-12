using Levent_Kurt_Csharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Levent_Kurt_Csharp.ViewComponents
{
    public class AltVideolar:ViewComponent
    {



        public async Task<IViewComponentResult> InvokeAsync(List<Response2> model)
        {

            return View(model);
        }




    }
}
