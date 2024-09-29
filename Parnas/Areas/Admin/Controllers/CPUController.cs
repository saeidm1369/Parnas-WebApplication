using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Cooling;
using Parnas.Domain.DTOs.CPU;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CPUController : Controller
    {       
        #region Field
        private readonly IGenericService<CPU, AccessoryImage> _genericService;
        #endregion

        #region Constructor

        public CPUController(IGenericService<CPU, AccessoryImage> genericService)
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
        public IActionResult Detail(int id)
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

            var result = _genericService.Add<CPUAddDto, AccessoryImage>(cpuAddDto, cpuAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateCPU(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var cpu = _genericService.GetById<CPUDetailDto>(id);
            return View(cpu);
        }

        [HttpPost]
        public IActionResult UpdateCPU(CPUUpdateDto cpuUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(cpuUpdateDto);
            var result = _genericService.Update<CPUUpdateDto>(cpuUpdateDto, cpuUpdateDto.Images, cpuUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteCPU(CPUListDto cpuDto)
        {
            if (cpuDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<CPUListDto>(cpuDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteCPU(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "CPU", new { area = "Admin" });
        }
        #endregion
    }
}
