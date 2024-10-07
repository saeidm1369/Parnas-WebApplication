using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Power;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Power;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PowerController : Controller
    {
        #region Field
        private readonly IGenericService<Power, PowerImage> _genericService;
        #endregion

        #region Constructor

        public PowerController(IGenericService<Power, PowerImage> genericService)
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
        public IActionResult Detail(int id)
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

            var result = _genericService.Add<PoweAddDto, GraphicCardImagr>(poweAddDto, poweAddDto.Images);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Power", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult UpdatePower(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var power = _genericService.GetById<PowerDetailDto>(id);
            return View(power);
        }

        [HttpPost]
        public IActionResult UpdatePower(PowerUpdateDto powerUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(powerUpdateDto);
            var result = _genericService.Update<PowerUpdateDto>(powerUpdateDto, powerUpdateDto.Images, powerUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Power", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult DeletePower(PowerListDto powerDto)
        {
            if (powerDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<PowerListDto>(powerDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeletePower(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Power", new { area = "Admin" });
        }
        #endregion
    }
}
