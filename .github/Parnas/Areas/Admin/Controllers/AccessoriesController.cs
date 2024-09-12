using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccessoriesController : Controller
    {
        #region Field
        private readonly IGenericService<Accessories> _genericService;
        #endregion

        #region Constructor

        public AccessoriesController(IGenericService<Accessories> genericService)
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
                var accessories = _genericService.GetAll<AccessoryListDto>().ToList();
                return View(accessories);
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

                return RedirectToAction(nameof(Index), new {controller = "Home"});
            }
        }

        [HttpGet]
        public IActionResult Detail(string id)
        {
            try
            {
                var result = _genericService.GetById<AccessoryDetailsDto>(id);
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
        public IActionResult AddAccessory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAccessory(AccessoryAddDto accessoryAddDto)
        {
            if (!ModelState.IsValid)
                return View(accessoryAddDto);

            var result = _genericService.Add<AccessoryAddDto>(accessoryAddDto);
            ViewData["Message"] = result.Title;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateAccessory(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var accessory = _genericService.GetById<AccessoryDetailsDto>(id);
            return View(accessory);
        }

        [HttpPost]
        public IActionResult UpdateAccessory(AccessoryDetailsDto accessory)
        {
            if (!ModelState.IsValid)
                return View(accessory);
            var result = _genericService.Update<AccessoryDetailsDto>(accessory.Id, accessory);
            ViewData["Message"] = result.Title;
            return View();
        }

        public IActionResult DeleteAccessory(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Title;
            return View();
        }
        #endregion
    }
}
