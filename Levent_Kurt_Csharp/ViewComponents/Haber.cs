using Levent_Kurt_Csharp.Models;
using Microsoft.AspNetCore.Mvc;
using Levent_Kurt_Csharp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;


namespace Levent_Kurt_Csharp.ViewComponents
{
	public class Haber:ViewComponent
	{

		public async Task<IViewComponentResult> InvokeAsync(List<Response> model)
		{
			
			return View(model);
		}
	}
}
