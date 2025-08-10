using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaludGest.Services.Interfaces;

namespace SaludGest.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitaService _citaService;
        private readonly ICustomExcepction _customExcepction;

        public CitaController(ICitaService citaService, ICustomExcepction customExcepction)
        {
            _citaService = citaService;
            _customExcepction = customExcepction;
        }

        public async Task<IActionResult> Index()
        {
            var citas = await _citaService.GetAllAsync();
            return View(citas);
        }
    }
}
