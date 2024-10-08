using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;

namespace Parnas.ViewComponents
{
    public class AccessoriesListComponent : ViewComponent
    {
        private IGenericService<Accessories, AccessoriesImage> _genericService;
        private readonly ILogger<AccessoriesListComponent> _logger;
        public AccessoriesListComponent(IGenericService<Accessories, AccessoriesImage> genericService, ILogger<AccessoriesListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var accessoriesList = _genericService.GetAll<AccessoryListDto>();
                IViewComponentResult result = View("AccessoriesList", accessoriesList); 
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving accessories list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
            
    }
}
