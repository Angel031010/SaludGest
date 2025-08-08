using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SaludGest.Constans;
using SaludGest.DTOs.Paciente;
using SaludGest.Services.Interfaces;
using static SaludGest.Utils.Enumeradores;

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

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var paciente = await _pacienteService.GetByIdAsync(id);
                if (paciente == null)
                {
                    return NotFound();
                }
                return PartialView("_PacienteDetailsPartial", paciente);
            }
            catch (Exception ex)
            {
                _customExcepction.GetExeption(ex);
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Generos = Enum.GetValues(typeof(Genero))
                         .Cast<Genero>()
                         .Select(g => new SelectListItem
                         {
                             Value = g.ToString(),   // se enviará como string al DTO
                             Text = g.ToString()
                         })
                         .ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PacienteCreateDTO pacienteCreateDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _pacienteService.AddAsync(pacienteCreateDTO);
                    TempData["SuccessMessage"] = Messages.Success.PacienteCreado;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorCrearPaciente}: {_customExcepction.GetExeption(ex)}";
            }
            return View(pacienteCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var paciente = await _pacienteService.GetByIdAsync(id);

                // Poblar lista de géneros
                ViewBag.Generos = Enum.GetValues(typeof(Genero))
                    .Cast<Genero>()
                    .Select(g => new SelectListItem
                    {
                        Value = g.ToString(),
                        Text = g.ToString(),
                        Selected = g.ToString() == paciente.Genero
                    })
                    .ToList();

                var pacienteEditDTO = paciente.Adapt<PacienteEditDTO>();
                return View(pacienteEditDTO);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.PacienteNoExiste} : {_customExcepction.GetExeption(ex)}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PacienteEditDTO pacienteEditDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _pacienteService.UpdateAsync(id, pacienteEditDTO);
                    TempData["SuccessMessage"] = Messages.Success.PacienteActualizado;
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                //throw;
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorActualizarPaciente}: {_customExcepction.GetExeption(ex)}";
            }

            ViewBag.Generos = Enum.GetValues(typeof(Genero))
                .Cast<Genero>()
                .Select(g => new SelectListItem
                {
                    Value = g.ToString(),
                    Text = g.ToString(),
                    Selected = g.ToString() == pacienteEditDTO.Genero
                })
                .ToList();

            return View(pacienteEditDTO);
        }


        [HttpGet]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            try
            {
                var paciente = await _pacienteService.GetByIdAsync(id);
                return View(paciente);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.PacienteNoExiste} :  {_customExcepction.GetExeption(ex)}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _pacienteService.DeleteAsync(id);
                TempData["SuccessMessage"] = Messages.Success.PacienteEliminado;
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorEliminarPaciente}: {_customExcepction.GetExeption(ex)}";
            }
            return RedirectToAction("Index");
        }
    }
}
