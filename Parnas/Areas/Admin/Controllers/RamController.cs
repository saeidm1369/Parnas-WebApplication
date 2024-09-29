using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Ram;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RamController : Controller
    {
        #region Field
        private readonly IGenericService<Ram, AccessoryImage> _genericService;
        #endregion

        #region Constructor

        public RamController(IGenericService<Ram, AccessoryImage> genericService)
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
                var rams = _genericService.GetAll<RamListDto>().ToList();
                return View(rams);
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
                var result = _genericService.GetById<RamDetailDto>(id);
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
        public IActionResult AddRam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRam(RamAddDto ramAddDto)
        {
            if (!ModelState.IsValid)
                return View(ramAddDto);

            var result = _genericService.Add<RamAddDto, AccessoryImage>(ramAddDto, ramAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRam(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var ram = _genericService.GetById<RamDetailDto>(id);
            return View(ram);
        }

        [HttpPost]
        public IActionResult UpdateRam(RamUpdateDto ramUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(ramUpdateDto);
            var result = _genericService.Update<RamUpdateDto>(ramUpdateDto, ramUpdateDto.Images, ramUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteRam(RamListDto ramDto)
        {
            if (ramDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<RamListDto>(ramDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteRam(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Ram", new { area = "Admin" });
        }
        #endregion
    }
}
