using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.MotherBoard;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    public class MotherBoardController : Controller
    {
        #region Field
        private readonly IGenericService<MotherBoard> _genericService;
        #endregion

        #region Constructor

        public MotherBoardController(IGenericService<MotherBoard> genericService)
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
                var motherBoard = _genericService.GetAll<MotherBoardListDto>().ToList();
                return View(motherBoard);
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
                var result = _genericService.GetById<MotherBoardDetailDto>(id);
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
        public IActionResult AddMotherBoard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMotherBoard(MotherBoardAddDto motherBoardAddDto)
        {
            if (!ModelState.IsValid)
                return View(motherBoardAddDto);

            var result = _genericService.Add<MotherBoardAddDto>(motherBoardAddDto, motherBoardAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateMotherBoard(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var motherBoard = _genericService.GetById<MotherBoardDetailDto>(id);
            return View(motherBoard);
        }

        [HttpPost]
        public IActionResult UpdateMotherBoard(MotherBoardDetailDto motherBoardDetailDto)
        {
            if (!ModelState.IsValid)
                return View(motherBoardDetailDto);
            var result = _genericService.Update<MotherBoardDetailDto>(motherBoardDetailDto.Id, motherBoardDetailDto, motherBoardDetailDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteMotherBoard(MotherBoardListDto motherBoardDto)
        {
            if (motherBoardDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<MotherBoardListDto>(motherBoardDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteMotherBoard(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "MotherBoard", new { area = "Admin" });
        }
        #endregion
    }
}
