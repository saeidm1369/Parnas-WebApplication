using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.SSD;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    public class SSDController : Controller
    {
        #region Field
        private readonly IGenericService<SSD> _genericService;
        #endregion

        #region Constructor

        public SSDController(IGenericService<SSD> genericService)
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
                var SSDs = _genericService.GetAll<SSDListDto>().ToList();
                return View(SSDs);
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
                var result = _genericService.GetById<SSDDetailDto>(id);
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
        public IActionResult AddSSD()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSSD(SSDAddDto ssdAddDto)
        {
            if (!ModelState.IsValid)
                return View(ssdAddDto);

            var result = _genericService.Add<SSDAddDto>(ssdAddDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateSSD(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var ssd = _genericService.GetById<SSDDetailDto>(id);
            return View(ssd);
        }

        [HttpPost]
        public IActionResult UpdateSSD(SSDDetailDto ssdDetailDto)
        {
            if (!ModelState.IsValid)
                return View(ssdDetailDto);
            var result = _genericService.Update<SSDDetailDto>(ssdDetailDto.Id, ssdDetailDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        public IActionResult DeleteSSD(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Title;
            return View();
        }
        #endregion
    }
}
