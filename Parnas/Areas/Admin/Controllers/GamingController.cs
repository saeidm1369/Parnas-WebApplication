using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Gaming;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GamingController : Controller
    {
        #region Field
        private readonly IGenericService<Gaming, AccessoryImage> _genericService;
        #endregion

        #region Constructor

        public GamingController(IGenericService<Gaming, AccessoryImage> genericService)
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
                var gamings = _genericService.GetAll<GamingListDto>().ToList();
                return View(gamings);
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
                var result = _genericService.GetById<GamingDetailDto>(id);
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
        public IActionResult AddGaming()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGaming(GamingAddDto gamingAddDto)
        {
            if (!ModelState.IsValid)
                return View(gamingAddDto);

            var result = _genericService.Add<GamingAddDto, AccessoryImage>(gamingAddDto, gamingAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateGaming(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var gaming = _genericService.GetById<GamingDetailDto>(id);
            return View(gaming);
        }

        [HttpPost]
        public IActionResult UpdateGaming(GamingUpdateDto gamingUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(gamingUpdateDto);
            var result = _genericService.Update<GamingUpdateDto>(gamingUpdateDto, gamingUpdateDto.Images, gamingUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteGaming(GamingListDto gamingDto)
        {
            if (gamingDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<GamingListDto>(gamingDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteGaming(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Gaming", new { area = "Admin" });
        }
        #endregion
    }
}
