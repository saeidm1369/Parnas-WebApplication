using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Gaming;
using Parnas.Domain.DTOs.Rendering;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Gaming;
using static Parnas.Domain.Entities.Rendering;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RenderingController : Controller
    {
        #region Field
        private readonly IGenericService<Rendering, RenderingImage> _genericService;
        #endregion

        #region Constructor

        public RenderingController(IGenericService<Rendering, RenderingImage> genericService)
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
                var renderings = _genericService.GetAll<RenderingListDto>().ToList();
                return View(renderings);
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
                var result = _genericService.GetById<RenderingDetailDto>(id);
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
        public IActionResult AddRendering()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRendering(RenderingAddDto renderingAddDto)
        {
            if (!ModelState.IsValid)
                return View(renderingAddDto);

            var result = _genericService.Add<RenderingAddDto, RenderingImage>(renderingAddDto, renderingAddDto.Images);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Rendering", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult UpdateRendering(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var rendering = _genericService.GetById<RenderingDetailDto>(id);
            return View(rendering);
        }

        [HttpPost]
        public IActionResult UpdateRendering(RenderingUpdateDto renderingUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(renderingUpdateDto);
            var result = _genericService.Update<RenderingUpdateDto>(renderingUpdateDto, renderingUpdateDto.Images, renderingUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Rendering", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult DeleteRendering(RenderingListDto renderingListDto)
        {
            if (renderingListDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<RenderingListDto>(renderingListDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteRendering(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "Rendering", new { area = "Admin" });
        }
        #endregion
    }
}
