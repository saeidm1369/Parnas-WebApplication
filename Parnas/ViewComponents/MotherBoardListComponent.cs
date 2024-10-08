using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.MotherBoard;

namespace Parnas.ViewComponents
{
    public class MotherBoardListComponent : ViewComponent
    {
        private IGenericService<MotherBoard, MotherBoardImage> _genericService;
        private readonly ILogger<MotherBoardListComponent> _logger;
        public MotherBoardListComponent(IGenericService<MotherBoard, MotherBoardImage> genericService, ILogger<MotherBoardListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var motherBoardList = _genericService.GetAll<CaseListDto>();
                IViewComponentResult result = View("MotherBoardList", motherBoardList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving motherBoard list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
