using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.Gaming;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Gaming;

namespace Parnas.ViewComponents
{
    public class GamingListComponenet : ViewComponent
    {
        private IGenericService<Gaming, GamingImage> _genericService;
        private readonly ILogger<GamingListComponenet> _logger;
        public GamingListComponenet(IGenericService<Gaming, GamingImage> genericService, ILogger<GamingListComponenet> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var gamingList = _genericService.GetAll<GamingListDto>();
                IViewComponentResult result = View("GamingList", gamingList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving gaming list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
