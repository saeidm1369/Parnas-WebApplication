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
        private readonly IGenericService<Gaming> _genericService;
        #endregion

        #region Constructor

        public GamingController(IGenericService<Gaming> genericService)
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
        public IActionResult Detail(string id)
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

            var result = _genericService.Add(gamingAddDto, gamingAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateGaming(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var gaming = _genericService.GetById<GamingDetailDto>(id);
            return View(gaming);
        }

        [HttpPost]
        public IActionResult UpdateGaming(GamingDetailDto gamingDetailDto)
        {
            if (!ModelState.IsValid)
                return View(gamingDetailDto);
            var result = _genericService.Update(gamingDetailDto.Id, gamingDetailDto, gamingDetailDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        public IActionResult DeleteGaming(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return View();
        }
        #endregion
    }
}
