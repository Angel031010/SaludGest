using Microsoft.AspNetCore.Mvc;
using SaludGest.Services.Interfaces;

namespace SaludGest.Controllers
{
    public class PacienteController : Controller
    {

        private readonly IPacienteService _pacienteService;
        private readonly ICustomExcepction _customExcepction;

        public PacienteController(IPacienteService pacienteService, ICustomExcepction customExcepction)
        {
            _pacienteService = pacienteService;
            _customExcepction = customExcepction;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pacientes = await _pacienteService.GetAllAsync();
            return View(pacientes);
        }
    }
}
