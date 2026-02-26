using Microsoft.AspNetCore.Mvc;

namespace AppSetting.Controllers
{
    public class ConfigController : Controller
    {
        private readonly IConfiguration _configuration;
        public ConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.AppName = _configuration["AppSettings:AppName"];
            ViewBag.AppVersion = _configuration["AppSettings:Version"];
            ViewBag.developer = _configuration["AppSettings:Developer"];
            return View();
        }
    }
}
