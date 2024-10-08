using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.FanCase;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.FanCase;

namespace Parnas.ViewComponents
{
    public class FanCaseListComponent : ViewComponent
    {
        private IGenericService<FanCase, FanCaseImage> _genericService;
        private readonly ILogger<FanCaseListComponent> _logger;
        public FanCaseListComponent(IGenericService<FanCase, FanCaseImage> genericService, ILogger<FanCaseListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var fanCaseList = _genericService.GetAll<FanCaseListDto>();
                IViewComponentResult result = View("FanCaseList", fanCaseList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving FanCase list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
