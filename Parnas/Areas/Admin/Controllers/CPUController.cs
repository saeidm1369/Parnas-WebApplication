using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.CPU;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CPUController : Controller
    {       
        #region Field
        private readonly IGenericService<CPU> _genericService;
        #endregion

        #region Constructor

        public CPUController(IGenericService<CPU> genericService)
        {
            _genericService = genericService;
        }
        #endregion

        #region Get

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var CPUs = _genericService.GetAll<CPUListDto>().ToList();
                return View(CPUs);
            }
            catch (ServiceException exception)
            {
                exception = ServiceException.Create(
                    type: "OperationFailed",
                    title: "خطا در انجام عملیات",
                    detail: "هنگام بارگذاری لیست محصول ها خطایی رخ داد. لطفا دوباره تلاش کنید.");

                ViewData["error"] = exception.Detail;

                if (exception.InnerException != null)
                {
                    ViewData["error"] += "" + exception.InnerException.Message;
                }

                return RedirectToAction(nameof(Index), new { controller = "Home" });
            }
        }

        [HttpGet]
        public IActionResult Detail(string id)
        {
            try
            {
                var result = _genericService.GetById<CPUDetailDto>(id);
                return View(result);
            }
            catch (ServiceException exception)
            {
                exception = ServiceException.Create(
                    type: "OperationFailed",
                    title: "خطا در انجام عملیات",
                    detail: "هنگام بارگذاری جزئیات محصول خطایی رخ داد. لطفا دوباره تلاش کنید.");

                ViewData["error"] = exception.Detail;

                if (exception.InnerException != null)
                {
                    ViewData["error"] += "" + exception.InnerException.Message;
                }

                return RedirectToAction(nameof(Index), new { controller = "Home" });
            }
        }
        #endregion

        #region CUD

        [HttpGet]
        public IActionResult AddCPU()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCPU(CPUAddDto cpuAddDto)
        {
            if (!ModelState.IsValid)
                return View(cpuAddDto);

            var result = _genericService.Add<CPUAddDto>(cpuAddDto, cpuAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateCPU(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var cpu = _genericService.GetById<CPUDetailDto>(id);
            return View(cpu);
        }

        [HttpPost]
        public IActionResult UpdateCPU(CPUDetailDto cpuDetailDto)
        {
            if (!ModelState.IsValid)
                return View(cpuDetailDto);
            var result = _genericService.Update<CPUDetailDto>(cpuDetailDto.Id, cpuDetailDto, cpuDetailDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        public IActionResult DeleteCPU(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return View();
        }
        #endregion
    }
}
