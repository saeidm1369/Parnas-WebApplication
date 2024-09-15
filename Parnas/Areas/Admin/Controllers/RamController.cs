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
        private readonly IGenericService<Ram> _genericService;
        #endregion

        #region Constructor

        public RamController(IGenericService<Ram> genericService)
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
        public IActionResult Detail(string id)
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

            var result = _genericService.Add<RamAddDto>(ramAddDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRam(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var ram = _genericService.GetById<RamDetailDto>(id);
            return View(ram);
        }

        [HttpPost]
        public IActionResult UpdateRam(RamDetailDto ramDetailDto)
        {
            if (!ModelState.IsValid)
                return View(ramDetailDto);
            var result = _genericService.Update<RamDetailDto>(ramDetailDto.Id, ramDetailDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        public IActionResult DeleteRam(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Title;
            return View();
        }
        #endregion
    }
}
