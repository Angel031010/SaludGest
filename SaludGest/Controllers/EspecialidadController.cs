using Mapster;
using Microsoft.AspNetCore.Mvc;
using SaludGest.Constans;
using SaludGest.DTOs.Especialidad;
using SaludGest.Services.Implementations;
using SaludGest.Services.Interfaces;
using System.Threading.Tasks;

namespace SaludGest.Controllers
{
    public class EspecialidadController : Controller
    {

        private readonly IEspecialidadService _especialidadService;
        private readonly ICustomExcepction _customExcepction;

        public EspecialidadController(IEspecialidadService especialidadService, ICustomExcepction customExcepction)
        {
            _especialidadService = especialidadService;
            _customExcepction = customExcepction;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var especialidades = await _especialidadService.GetAllAsync();
            return View(especialidades);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var especialidad = await _especialidadService.GetByIdAsync(id);
                if (especialidad == null)
                {
                    return NotFound();
                }
                return PartialView("_EspecialidadDetailsPartial", especialidad);
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EspecialidadCreateDTO especialidadDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _especialidadService.AddAsync(especialidadDTO);
                    TempData["SuccessMessage"] = Messages.Success.EspecialidadCreada;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorCrearEspecialidad}: {_customExcepction.GetExeption(ex)}";
            }
            return View(especialidadDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var especialidadDTO = await _especialidadService.GetByIdAsync(id);
                var especialidadCreateDTO = especialidadDTO.Adapt<EspecialidadCreateDTO>();
                return View(especialidadCreateDTO);
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = Messages.Error.EspecialidadNoExiste;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EspecialidadCreateDTO especialidadCreateDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _especialidadService.UpdateAsync(id, especialidadCreateDTO);
                    TempData["SuccessMessage"] = Messages.Success.EspecialidadActualizada;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = Messages.Error.ErrorActualizarEspecialidad;
            }

            return View(especialidadCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            try
            {
                var especialidadDTO = await _especialidadService.GetByIdAsync(id);
                return View(especialidadDTO);
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = Messages.Error.EspecialidadNoExiste;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _especialidadService.DeleteAsync(id);
                TempData["SuccessMessage"] = Messages.Success.EspecialidadEliminada;
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = Messages.Error.EspecialidadNoExiste;
            }
            return RedirectToAction("Index");
        }

    }
}
