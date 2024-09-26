using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CaseController : Controller
    {
        #region Field
        private readonly IGenericService<Case, AccessoryImage> _genericService;
        #endregion

        #region Constructor

        public CaseController(IGenericService<Case, AccessoryImage> genericService)
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
                var Cases = _genericService.GetAll<CaseListDto>().ToList();
                return View(Cases);
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
                var result = _genericService.GetById<CaseDetailDto>(id);
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
        public IActionResult AddCase()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCase(CaseAddDto caseAddDto)
        {
            if (!ModelState.IsValid)
                return View(caseAddDto);

            var result = _genericService.Add<CaseAddDto, AccessoryImage>(caseAddDto, caseAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateCase(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var updatcase = _genericService.GetById<CaseDetailDto>(id);
            return View(updatcase);
        }

        [HttpPost]
        public IActionResult UpdateCase(CaseAddDto caseAddDto)
        {
            if (!ModelState.IsValid)
                return View(caseAddDto);
            var result = _genericService.Update<CaseAddDto>(caseAddDto, caseAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteCase(CaseListDto caseDto)
        {
            if (caseDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<CaseListDto>(caseDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteCase(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Case", new { area = "Admin" });
        }
        #endregion
    }
}
