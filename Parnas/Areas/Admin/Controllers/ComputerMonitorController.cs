﻿using DomainServices.Exception;
using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.ComputerMonitor;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.ComputerMonitor;

namespace Parnas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ComputerMonitorController : Controller
    {
        #region Field
        private readonly IGenericService<ComputerMonitor, ComputerMonitorImage> _genericService;
        #endregion

        #region Constructor

        public ComputerMonitorController(IGenericService<ComputerMonitor, ComputerMonitorImage> genericService)
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
                var monitors = _genericService.GetAll<ComputerMonitorListDto>().ToList();
                return View(monitors);
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
                var result = _genericService.GetById<ComputerMonitorListDto>(id);
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
        public IActionResult AddMonitor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMonitor(ComputerMonitorAddDto monitorAddDto)
        {
            if (!ModelState.IsValid)
                return View(monitorAddDto);

            var result = _genericService.Add<ComputerMonitorAddDto, ComputerMonitorImage>(monitorAddDto, monitorAddDto.Images);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "ComputerMonitor", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult UpdateMonitor(int id)
        {
            if (id == 0)
                ViewData["Message"] = "Null";
            var monitor = _genericService.GetById<ComputerMonitorDetailDto>(id);
            return View(monitor);
        }

        [HttpPost]
        public IActionResult UpdateMonitor(ComputerMonitorUpdateDto monitorUpdateDto)
        {
            if (!ModelState.IsValid)
                return View(monitorUpdateDto);
            var result = _genericService.Update<ComputerMonitorUpdateDto>(monitorUpdateDto, monitorUpdateDto.Images, monitorUpdateDto.Id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "ComputerMonitor", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult DeleteMonitor(ComputerMonitorListDto monitorDto)
        {
            if (monitorDto.Id == 0)
                ViewData["Message"] = "Null";
            var result = _genericService.GetById<ComputerMonitorListDto>(monitorDto.Id);
            return View(result);
        }

        [HttpPost]
        public IActionResult DeleteMonitor(int id)
        {
            var result = _genericService.Delete(id);
            ViewData["Message"] = result.Type;
            return RedirectToAction("Index", "ComputerMonitor", new { area = "Admin" });
        }
        #endregion
    }
}
