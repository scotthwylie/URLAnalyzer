using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using URLAnalyzer.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using URLAnalyzer.Services;
using System.Threading.Tasks;

namespace URLAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IURLAnalyzerService _urlAnalyzerService;

        public HomeController(IURLAnalyzerService service)
        {
            _urlAnalyzerService = service;
        }

        public IActionResult Index()
        {
            IndexModel model = new IndexModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult LoadUrl(IndexModel indexModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            LoadUrlModel model = _urlAnalyzerService.GetUrlModel(indexModel.Url);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
