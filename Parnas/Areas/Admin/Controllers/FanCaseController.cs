using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.FanCase;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FanCaseController : Controller
    {
        #region Field
        private readonly IGenericService<FanCase, AccessoryImage> _genericService;
        #endregion

        #region Constructor

        public FanCaseController(IGenericService<FanCase, AccessoryImage> genericService)
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
                var FanCases = _genericService.GetAll<FanCaseListDto>().ToList();
                return View(FanCases);
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
                var result = _genericService.GetById<FanCaseDetailDto>(id);
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
        public IActionResult AddFanCase()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFanCase(FaneCaseAddDto faneCaseAddDto)
        {
            if (!ModelState.IsValid)
                return View(faneCaseAddDto);

            var result = _genericService.Add<FaneCaseAddDto, AccessoryImage>(faneCaseAddDto, faneCaseAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateFanCase(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var fancase = _genericService.GetById<FanCaseDetailDto>(id);
            return View(fancase);
        }

        [HttpPost]
        public IActionResult UpdateFanCase(FanCaseUpdateDto faneCaseUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(faneCaseUpdateDto);
            var result = _genericService.Update<FanCaseUpdateDto>(faneCaseUpdateDto, faneCaseUpdateDto.Images, faneCaseUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteFanCase(FanCaseListDto fanCaseDto)
        {
            if (fanCaseDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<FanCaseListDto>(fanCaseDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteFanCase(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "FanCase", new { area = "Admin" });
        }
        #endregion
    }
}
