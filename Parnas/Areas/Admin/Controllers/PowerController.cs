using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Power;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PowerController : Controller
    {
        #region Field
        private readonly IGenericService<Power> _genericService;
        #endregion

        #region Constructor

        public PowerController(IGenericService<Power> genericService)
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
                var powers = _genericService.GetAll<PowerListDto>().ToList();
                return View(powers);
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
                var result = _genericService.GetById<PowerDetailDto>(id);
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
        public IActionResult AddPower()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPower(PoweAddDto poweAddDto)
        {
            if (!ModelState.IsValid)
                return View(poweAddDto);

            var result = _genericService.Add<PoweAddDto>(poweAddDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        [HttpGet]
        public IActionResult UpdatePower(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var power = _genericService.GetById<PowerDetailDto>(id);
            return View(power);
        }

        [HttpPost]
        public IActionResult UpdatePower(PowerDetailDto powerDetailDto)
        {
            if (!ModelState.IsValid)
                return View(powerDetailDto);
            var result = _genericService.Update<PowerDetailDto>(powerDetailDto.Id, powerDetailDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        public IActionResult DeletePower(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Title;
            return View();
        }
        #endregion
    }
}
