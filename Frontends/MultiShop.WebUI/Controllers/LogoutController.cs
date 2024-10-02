using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Services.IdentityServices.Interfaces;

namespace MultiShop.WebUI.Controllers
{
    public class LogoutController : Controller
    {
        private readonly IIdentityService _identityService;

        public LogoutController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _identityService.SignOut();
            return RedirectToAction("Index", "Default");

        }
    }
}
