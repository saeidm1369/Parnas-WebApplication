using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.SSD;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.SSD;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SSDController : Controller
    {
        #region Field
        private readonly IGenericService<SSD, SSDImage> _genericService;
        #endregion

        #region Constructor

        public SSDController(IGenericService<SSD, SSDImage> genericService)
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
        public IActionResult Detail(int id)
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

            var result = _genericService.Add<SSDAddDto, GraphicCardImagr>(ssdAddDto, ssdAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateSSD(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var ssd = _genericService.GetById<SSDDetailDto>(id);
            return View(ssd);
        }

        [HttpPost]
        public IActionResult UpdateSSD(SSDUpdateDto ssdUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(ssdUpdateDto);
            var result = _genericService.Update<SSDUpdateDto>(ssdUpdateDto, ssdUpdateDto.Images, ssdUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteSSD(SSDListDto ssdDto)
        {
            if (ssdDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<SSDListDto>(ssdDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteSSD(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "SSD", new { area = "Admin" });
        }
        #endregion
    }
}
