using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.Power;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Power;

namespace Parnas.ViewComponents
{
    public class PowerListComponent : ViewComponent
    {
        private IGenericService<Power, PowerImage> _genericService;
        private readonly ILogger<PowerListComponent> _logger;
        public PowerListComponent(IGenericService<Power, PowerImage> genericService, ILogger<PowerListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var powerList = _genericService.GetAll<PowerListDto>();
                IViewComponentResult result = View("PowerList", powerList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Power list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
