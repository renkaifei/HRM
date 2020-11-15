using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HRM.WebUI.Controllers
{
    public class LoginController:Controller
    {
        private readonly ILogger<LoginController> logger;
        public LoginController(ILogger<LoginController> logger)
        {
            this.logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}