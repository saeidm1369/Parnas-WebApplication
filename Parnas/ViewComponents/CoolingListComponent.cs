using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.Cooling;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Cooling;

namespace Parnas.ViewComponents
{
    public class CoolingListComponent : ViewComponent
    {
        private IGenericService<Cooling, CoolingImage> _genericService;
        private readonly ILogger<CoolingListComponent> _logger;
        public CoolingListComponent(IGenericService<Cooling, CoolingImage> genericService, ILogger<CoolingListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var coolingList = _genericService.GetAll<CoolingListDto>();
                IViewComponentResult result = View("CoolingList", coolingList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving cooling list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}