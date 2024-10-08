using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.CPU;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.CPU;

namespace Parnas.ViewComponents
{
    public class CPUListComponent : ViewComponent
    {
        private IGenericService<CPU, CPUImage> _genericService;
        private readonly ILogger<CPUListComponent> _logger;
        public CPUListComponent(IGenericService<CPU, CPUImage> genericService, ILogger<CPUListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var cpuList = _genericService.GetAll<CPUListDto>();
                IViewComponentResult result = View("CPUList", cpuList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving cpu list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
