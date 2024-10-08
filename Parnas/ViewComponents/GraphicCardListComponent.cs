using Microsoft.AspNetCore.Mvc;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.GraphicCard;
using Parnas.Domain.Entities;
using Parnas.DomainService.Services;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.GraphicCard;

namespace Parnas.ViewComponents
{
    public class GraphicCardListComponent : ViewComponent
    {
        private IGenericService<GraphicCard, GraphicCardImage> _genericService;
        private readonly ILogger<GraphicCardListComponent> _logger;
        public GraphicCardListComponent(IGenericService<GraphicCard, GraphicCardImage> genericService, ILogger<GraphicCardListComponent> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }
        public Task<IViewComponentResult> Invoke()
        {
            try
            {
                var graphicCardList = _genericService.GetAll<GraphicCardListDto>();
                IViewComponentResult result = View("GraphicCardList", graphicCardList);
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving graphicCard list.");
                IViewComponentResult errorResult = View("Error");
                return Task.FromResult(errorResult);
            }
        }
    }
}
