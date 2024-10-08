using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.SSD;

namespace Parnas.ViewComponents
{
    public class SSDListComponent : ViewComponent
    {
        private IGenericService<SSD, SSDImage> _genericService;
        private readonly ILogger<SSDListComponent> _logger;
        public SSDListComponent(IGenericService<SSD, SSDImage> genericService, ILogger<SSDListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var ssdList = _genericService.GetAll<CaseListDto>();
                IViewComponentResult result = View("SSDList", ssdList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving ssd list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
