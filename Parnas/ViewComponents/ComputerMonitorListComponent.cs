using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.ComputerMonitor;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.ComputerMonitor;

namespace Parnas.ViewComponents
{
    public class ComputerMonitorListComponent : ViewComponent
    {
        private IGenericService<ComputerMonitor, ComputerMonitorImage> _genericService;
        private readonly ILogger<ComputerMonitorListComponent> _logger;
        public ComputerMonitorListComponent(IGenericService<ComputerMonitor, ComputerMonitorImage> genericService, ILogger<ComputerMonitorListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var monitorList = _genericService.GetAll<ComputerMonitorListDto>();
                IViewComponentResult result = View("MonitorList", monitorList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving monitor list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}