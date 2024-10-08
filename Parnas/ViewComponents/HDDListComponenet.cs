using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.HDD;

namespace Parnas.ViewComponents
{
    public class HDDListComponenet : ViewComponent
    {
        private IGenericService<HDD, HDDImage> _genericService;
        private readonly ILogger<HDDListComponenet> _logger;
        public HDDListComponenet(IGenericService<HDD, HDDImage> genericService, ILogger<HDDListComponenet> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var hddList = _genericService.GetAll<CaseListDto>();
                IViewComponentResult result = View("HDDList", hddList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving hdd list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
