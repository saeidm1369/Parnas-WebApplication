using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Ram;

namespace Parnas.ViewComponents
{
    public class RamListComponent : ViewComponent
    {
        private IGenericService<Ram, RamImage> _genericService;
        private readonly ILogger<RamListComponent> _logger;
        public RamListComponent(IGenericService<Ram, RamImage> genericService, ILogger<RamListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var ramList = _genericService.GetAll<CaseListDto>();
                IViewComponentResult result = View("RamList", ramList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving ram list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}