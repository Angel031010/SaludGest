using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SaludGest.Constans;
using SaludGest.DTOs.Cita;
using SaludGest.Services.Interfaces;

namespace SaludGest.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitaService _citaService;
        private readonly ICustomExcepction _customExcepction;
        private readonly IMedicoService _medicoService;
        private readonly IPacienteService _pacienteService;

        public CitaController(
            ICitaService citaService,
            ICustomExcepction customExcepction,
            IMedicoService medicoService,
            IPacienteService pacienteService)
        {
            _citaService = citaService;
            _customExcepction = customExcepction;
            _medicoService = medicoService;
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var citas = await _citaService.GetAllAsync();
            return View(citas);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var cita = await _citaService.GetByIdAsync(id);
                if (cita == null)
                    return NotFound();

                return PartialView("_CitaDetailsPartial", cita);
            }
            catch (Exception ex)
            {
                _customExcepction.GetExeption(ex);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await CargarListasAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CitaCreateDTO citaCreateDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _citaService.AddAsync(citaCreateDTO);
                    TempData["SuccessMessage"] = Messages.Success.CitaCreada;
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorCrearCita}: {_customExcepction.GetExeption(ex)}";
            }

            await CargarListasAsync();
            return View(citaCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var citaDTO = await _citaService.GetByIdAsync(id);
                var citaEditDTO = citaDTO.Adapt<CitaCreateDTO>();

                await CargarListasAsync(citaDTO.MedicoId, citaDTO.PacienteId);

                return View(citaEditDTO);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.CitaNoExiste}: {_customExcepction.GetExeption(ex)}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CitaCreateDTO citaReadDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _citaService.UpdateAsync(id, citaReadDTO);
                    TempData["SuccessMessage"] = Messages.Success.CitaActualizada;
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorActualizarCita}: {_customExcepction.GetExeption(ex)}";
            }

            await CargarListasAsync(citaReadDTO.MedicoId, citaReadDTO.PacienteId);
            return View(citaReadDTO);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            try
            {
                var cita = await _citaService.GetByIdAsync(id);
                return View(cita);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.CitaNoExiste}: {_customExcepction.GetExeption(ex)}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _citaService.DeleteAsync(id);
                TempData["SuccessMessage"] = Messages.Success.CitaEliminada;
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorEliminarCita}: {_customExcepction.GetExeption(ex)}";
            }
            return RedirectToAction(nameof(Index));
        }

        // Método auxiliar para cargar listas desplegables de Médicos y Pacientes
        private async Task CargarListasAsync(int? medicoSeleccionado = null, int? pacienteSeleccionado = null)
        {
            var medicos = await _medicoService.GetAllAsync();
            var pacientes = await _pacienteService.GetAllAsync();

            ViewBag.Medicos = new SelectList(medicos, "MedicoId", "Nombre", medicoSeleccionado);
            ViewBag.Pacientes = new SelectList(pacientes, "PacienteId", "Nombre", pacienteSeleccionado);
        }
    }
}
