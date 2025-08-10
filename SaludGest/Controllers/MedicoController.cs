using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SaludGest.Constans;
using SaludGest.DTOs.Medico;
using SaludGest.Services.Implementations;
using SaludGest.Services.Interfaces;

namespace SaludGest.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicoService _medicoService;
        private readonly ICustomExcepction _customExcepction;
        private readonly IEspecialidadService _especialidadService;
        private readonly IDepartamentoService _departamentoService;

        public MedicoController(IMedicoService medicoService,
            ICustomExcepction customExcepction,
            IEspecialidadService especialidadService,
            IDepartamentoService departamentoService)
        {
            _medicoService = medicoService;
            _customExcepction = customExcepction;
            _especialidadService = especialidadService;
            _departamentoService = departamentoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pacientes = await _medicoService.GetAllAsync();
            return View(pacientes);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var medico = await _medicoService.GetByIdAsync(id);
                if (medico == null)
                {
                    return NotFound();
                }
                return PartialView("_MedicoDetailsPartial", medico);
            }
            catch (Exception ex)
            {
                _customExcepction.GetExeption(ex);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var especialidades = await _especialidadService.GetAllAsync();
            var departamentos = await _departamentoService.GetAllAsync();

            ViewBag.Especialidades = new SelectList(especialidades, "EspecialidadId", "NombreEspecialidad");
            ViewBag.Departamentos = new SelectList(departamentos, "DepartamentoId", "NombreDepartamento");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MedicoCreateDTO medicoCreateDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _medicoService.AddAsync(medicoCreateDTO);
                    TempData["SuccessMessage"] = Messages.Success.MedicoCreado;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorCrearMedico}: {_customExcepction.GetExeption(ex)}";
            }

            var especialidades = await _especialidadService.GetAllAsync();
            var departamentos = await _departamentoService.GetAllAsync();
            ViewBag.Especialidades = new SelectList(especialidades, "EspecialidadId", "NombreEspecialidad");
            ViewBag.Departamentos = new SelectList(departamentos, "DepartamentoId", "NombreDepartamento");

            return View(medicoCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var medicoDTO = await _medicoService.GetByIdAsync(id);

                var especialidades = await _especialidadService.GetAllAsync();
                var departamentos = await _departamentoService.GetAllAsync();
                ViewBag.Especialidades = new SelectList(especialidades, "EspecialidadId", "NombreEspecialidad");
                ViewBag.Departamentos = new SelectList(departamentos, "DepartamentoId", "NombreDepartamento");

                var medicoCreateDTO = medicoDTO.Adapt<MedicoCreateDTO>();

                return View(medicoCreateDTO);
            }
            catch (ApplicationException e)
            {
                TempData["ErrorMessage"] = Messages.Error.MedicoNoExiste;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MedicoCreateDTO medicoCreateDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _medicoService.UpdateAsync(id, medicoCreateDTO);
                    TempData["SuccessMessage"] = Messages.Success.MedicoActualizado;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = Messages.Error.ErrorActualizarMedico;
            }

            var especialidades = await _especialidadService.GetAllAsync();
            var departamentos = await _departamentoService.GetAllAsync();
            ViewBag.Especialidades = new SelectList(especialidades, "EspecialidadId", "NombreEspecialidad");
            ViewBag.Departamentos = new SelectList(departamentos, "DepartamentoId", "NombreDepartamento");

            return View(medicoCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            try
            {
                var product = await _medicoService.GetByIdAsync(id);
                return View(product);

            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = $"{Messages.Error.ErrorEliminarMedico} : {_customExcepction.GetExeption(e)}";
                return View("Index");
            }


        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _medicoService.DeleteAsync(id);
                TempData["SuccessMessage"] = Messages.Success.MedicoEliminado;
            }
            catch
            {
                TempData["ErrorMessage"] = Messages.Error.ErrorEliminarMedico;
            }
            return RedirectToAction("Index");
        }
    }
}
