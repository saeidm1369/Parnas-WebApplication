using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;

namespace Parnas.ViewComponents
{
    public class CaseListComponent : ViewComponent
    {
        private IGenericService<Case, CaseImage> _genericService;
        private readonly ILogger<CaseListComponent> _logger;
        public CaseListComponent(IGenericService<Case, CaseImage> genericService, ILogger<CaseListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var caseList = _genericService.GetAll<CaseListDto>();
                IViewComponentResult result = View("CaseList", caseList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving case list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
