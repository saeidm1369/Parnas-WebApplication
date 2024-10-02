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
        private readonly IGenericService<Accessories, GraphicCardImagr> _genericService;
        #endregion

        #region Constructor

        public AccessoriesController(IGenericService<Accessories, GraphicCardImagr> genericService)
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
        public IActionResult Detail(int id)
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

            var result = _genericService.Add<AccessoryAddDto, GraphicCardImagr> (accessoryAddDto, accessoryAddDto.Images);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Accessories", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult UpdateAccessory(int id)
       {
            if (id == 0)
                ViewData["Message"] = "Null";
            var accessory = _genericService.GetById<AccessoryDetailsDto>(id);
            return View(accessory);
        }

        [HttpPost]
        public IActionResult UpdateAccessory(AccessoryUpdateDto accessoryUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(accessoryUpdateDto);
            var result = _genericService.Update<AccessoryUpdateDto>(accessoryUpdateDto, accessoryUpdateDto.ImageList, accessoryUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Accessories", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult DeleteAccessory(AccessoryListDto accessory)
        {
            if (accessory.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<AccessoryListDto>(accessory.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteAccessory(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Accessories", new {area="Admin"});
        }
        #endregion
    }
}
