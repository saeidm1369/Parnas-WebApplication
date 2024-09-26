using AutoMapper;
using Parnas.Domain.DTOs.Accessories;
using Parnas.Domain.DTOs.Case;
using Parnas.Domain.DTOs.ComputerMonitor;
using Parnas.Domain.DTOs.Cooling;
using Parnas.Domain.DTOs.CPU;
using Parnas.Domain.DTOs.FanCase;
using Parnas.Domain.DTOs.Gaming;
using Parnas.Domain.DTOs.GraphicCard;
using Parnas.Domain.DTOs.HDD;
using Parnas.Domain.DTOs.MotherBoard;
using Parnas.Domain.DTOs.Power;
using Parnas.Domain.DTOs.Ram;
using Parnas.Domain.DTOs.SSD;
using Parnas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.DomainService.MapSetting
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Accesories Map
            CreateMap<Accessories, AccessoryAddDto>();
            CreateMap<Accessories, AccessoryDetailsDto>();
            CreateMap<Accessories, AccessoryListDto>();

            CreateMap<AccessoryAddDto, Accessories>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region Cases Map        
            CreateMap<Case, CaseAddDto>();
            CreateMap<Case, CaseDetailDto>();
            CreateMap<Case, CaseListDto>();
            #endregion

            #region ComputerMonitor Map
            CreateMap<ComputerMonitor, ComputerMonitorAddDto>();
            CreateMap<ComputerMonitor, ComputerMonitorDetailDto>();
            CreateMap<ComputerMonitor, ComputerMonitorListDto>();
            #endregion

            #region Cooling Map
            CreateMap<Cooling, CoolingAddDto>();
            CreateMap<Cooling, CoolingDetailDto>();
            CreateMap<Cooling, CoolingListDto>();
            #endregion

            #region CPU Map
            CreateMap<CPU, CPUAddDto>();
            CreateMap<CPU, CPUDetailDto>();
            CreateMap<CPU, CPUListDto>();
            #endregion

            #region FanCase Map
            CreateMap<FanCase, FanCaseDetailDto>();
            CreateMap<FanCase, FaneCaseAddDto>();
            CreateMap<FanCase, FanCaseListDto>();
            #endregion

            #region Gaming Map
            CreateMap<Gaming, GamingAddDto>();
            CreateMap<Gaming, GamingDetailDto>();
            CreateMap<Gaming, GamingListDto>();
            #endregion

            #region GraphicCard Map
            CreateMap<GraphicCard, GraphicCardAddDto>();
            CreateMap<GraphicCard, GraphicCardDetailDto>();
            CreateMap<GraphicCard, GraphicCardListDto>();
            #endregion

            #region HDD Map
            CreateMap<HDD, HDDAddDto>();
            CreateMap<HDD, HDDDetailDto>();
            CreateMap<HDD, HDDListDto>();
            #endregion

            #region MotherBoard Map
            CreateMap<MotherBoard, MotherBoardAddDto>();
            CreateMap<MotherBoard, MotherBoardDetailDto>();
            CreateMap<MotherBoard, MotherBoardListDto>();
            #endregion

            #region Power Map
            CreateMap<Power, PoweAddDto>();
            CreateMap<Power, PowerDetailDto>();
            CreateMap<Power, PowerListDto>();
            #endregion

            #region Ram Map
            CreateMap<Ram, RamAddDto>();
            CreateMap<Ram, RamDetailDto>();
            CreateMap<Ram, RamListDto>();
            #endregion

            #region SSD Map
            CreateMap<SSD, SSDAddDto>();
            CreateMap<SSD, SSDDetailDto>();
            CreateMap<SSD, SSDListDto>();
            #endregion

            
        }
    }
}
