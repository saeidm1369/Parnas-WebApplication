using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Cooling;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoolingController : Controller
    {
        #region Field
        private readonly IGenericService<Cooling> _genericService;
        #endregion

        #region Constructor

        public CoolingController(IGenericService<Cooling> genericService)
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
                var coolings = _genericService.GetAll<CoolingListDto>().ToList();
                return View(coolings);
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
                var result = _genericService.GetById<CoolingDetailDto>(id);
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
        public IActionResult AddCooling()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCooling(CoolingAddDto coolingAddDto)
        {
            if (!ModelState.IsValid)
                return View(coolingAddDto);

            var result = _genericService.Add<CoolingAddDto>(coolingAddDto, coolingAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateMonitor(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var monitor = _genericService.GetById<CoolingDetailDto>(id);
            return View(monitor);
        }

        [HttpPost]
        public IActionResult UpdateMonitor(CoolingDetailDto coolingDetailDto)
        {
            if (!ModelState.IsValid)
                return View(coolingDetailDto);
            var result = _genericService.Update<CoolingDetailDto>(coolingDetailDto.Id, coolingDetailDto, coolingDetailDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        public IActionResult DeleteMonitor(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return View();
        }
        #endregion
    }
}
