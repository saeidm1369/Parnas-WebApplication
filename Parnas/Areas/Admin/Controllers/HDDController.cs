using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.HDD;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HDDController : Controller
    {
        #region Field
        private readonly IGenericService<HDD> _genericService;
        #endregion

        #region Constructor

        public HDDController(IGenericService<HDD> genericService)
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
                var HDDs = _genericService.GetAll<HDDListDto>().ToList();
                return View(HDDs);
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
                var result = _genericService.GetById<HDDDetailDto>(id);
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
        public IActionResult AddHDD()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHDD(HDDAddDto hddAddDto)
        {
            if (!ModelState.IsValid)
                return View(hddAddDto);

            var result = _genericService.Add<HDDAddDto>(hddAddDto, hddAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateHDD(string id)
        {
            if (id == null)
                ViewData["Message"] = "Null";
            var accessory = _genericService.GetById<HDDDetailDto>(id);
            return View(accessory);
        }

        [HttpPost]
        public IActionResult UpdateHDD(HDDDetailDto hddDetailDto)
        {
            if (!ModelState.IsValid)
                return View(hddDetailDto);
            var result = _genericService.Update<HDDDetailDto>(hddDetailDto.Id, hddDetailDto, hddDetailDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        public IActionResult DeleteHDD(string id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return View();
        }
        #endregion
    }
}
