using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.GraphicCard;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GraphicCardController : Controller
    {
        #region Field
        private readonly IGenericService<GraphicCard> _genericService;
        #endregion

        #region Constructor

        public GraphicCardController(IGenericService<GraphicCard> genericService)
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
                var graphicCards = _genericService.GetAll<GraphicCardListDto>().ToList();
                return View(graphicCards);
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
                var result = _genericService.GetById<GraphicCardDetailDto>(id);
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
        public IActionResult AddGraphicCard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGraphicCard(GraphicCardAddDto graphicCardAddDto)
        {
            if (!ModelState.IsValid)
                return View(graphicCardAddDto);

            var result = _genericService.Add<GraphicCardAddDto>(graphicCardAddDto, graphicCardAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateGraphicCard(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var graphicCard = _genericService.GetById<AccessoryDetailsDto>(id);
            return View(graphicCard);
        }

        [HttpPost]
        public IActionResult UpdateGraphicCard(GraphicCardAddDto graphicCardAddDto)
        {
            if (!ModelState.IsValid)
                return View(graphicCardAddDto);
            var result = _genericService.Update<GraphicCardAddDto>(graphicCardAddDto, graphicCardAddDto.Images);
            ViewData["Message"] = result.Type;
            return View();
        }

        [HttpGet]
        public IActionResult DeleteGraphicCard(GraphicCardListDto graphicCardDto)
        {
            if (graphicCardDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<GraphicCardListDto>(graphicCardDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteGraphicCard(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "GraphicCard", new { area = "Admin" });
        }
        #endregion
    }
}
