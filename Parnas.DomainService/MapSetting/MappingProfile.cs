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
            CreateMap<Accessories, AccessoryUpdateDto>();

            CreateMap<AccessoryAddDto, Accessories>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<AccessoryUpdateDto, Accessories>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());

            #endregion

            #region Cases Map        
            CreateMap<Case, CaseAddDto>();
            CreateMap<Case, CaseDetailDto>();
            CreateMap<Case, CaseListDto>();
            CreateMap<Case, CaseUpdateDto>();

            CreateMap<CaseAddDto, Case>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<CaseUpdateDto, Case>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region ComputerMonitor Map
            CreateMap<ComputerMonitor, ComputerMonitorAddDto>();
            CreateMap<ComputerMonitor, ComputerMonitorDetailDto>();
            CreateMap<ComputerMonitor, ComputerMonitorListDto>();
            CreateMap<ComputerMonitor, ComputerMonitorUpdateDto>();

            CreateMap<ComputerMonitorAddDto, ComputerMonitor>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<ComputerMonitorUpdateDto, ComputerMonitor>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region Cooling Map
            CreateMap<Cooling, CoolingAddDto>();
            CreateMap<Cooling, CoolingDetailDto>();
            CreateMap<Cooling, CoolingListDto>();
            CreateMap<Cooling, CoolingUpdateDto>();

            CreateMap<CoolingAddDto, Cooling>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<CoolingUpdateDto, Cooling>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region CPU Map
            CreateMap<CPU, CPUAddDto>();
            CreateMap<CPU, CPUDetailDto>();
            CreateMap<CPU, CPUListDto>();
            CreateMap<CPU, CPUUpdateDto>();

            CreateMap<CPUAddDto, CPU>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<CPUUpdateDto, CPU>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region FanCase Map
            CreateMap<FanCase, FanCaseDetailDto>();
            CreateMap<FanCase, FaneCaseAddDto>();
            CreateMap<FanCase, FanCaseListDto>();
            CreateMap<FanCase, FanCaseUpdateDto>();

            CreateMap<FaneCaseAddDto, FanCase>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<FanCaseUpdateDto, FanCase>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region Gaming Map
            CreateMap<Gaming, GamingAddDto>();
            CreateMap<Gaming, GamingDetailDto>();
            CreateMap<Gaming, GamingListDto>();
            CreateMap<Gaming, GamingUpdateDto>();

            CreateMap<GamingAddDto, Gaming>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<GamingUpdateDto, Gaming>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region GraphicCard Map
            CreateMap<GraphicCard, GraphicCardAddDto>();
            CreateMap<GraphicCard, GraphicCardDetailDto>();
            CreateMap<GraphicCard, GraphicCardListDto>();
            CreateMap<GraphicCard, GraphicCardUpdateDto>();

            CreateMap<GraphicCardAddDto, GraphicCard>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<GraphicCardUpdateDto, GraphicCard>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region HDD Map
            CreateMap<HDD, HDDAddDto>();
            CreateMap<HDD, HDDDetailDto>();
            CreateMap<HDD, HDDListDto>();
            CreateMap<HDD, HDDUpdateDto>();

            CreateMap<HDDAddDto, HDD>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<HDDUpdateDto, HDD>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region MotherBoard Map
            CreateMap<MotherBoard, MotherBoardAddDto>();
            CreateMap<MotherBoard, MotherBoardDetailDto>();
            CreateMap<MotherBoard, MotherBoardListDto>();
            CreateMap<MotherBoard, MotherBoardUpdateDto>();

            CreateMap<MotherBoardAddDto, MotherBoard>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<MotherBoardUpdateDto, MotherBoard>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region Power Map
            CreateMap<Power, PoweAddDto>();
            CreateMap<Power, PowerDetailDto>();
            CreateMap<Power, PowerListDto>();
            CreateMap<Power, PowerUpdateDto>();

            CreateMap<PoweAddDto, Power>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<PowerUpdateDto, Power>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region Ram Map
            CreateMap<Ram, RamAddDto>();
            CreateMap<Ram, RamDetailDto>();
            CreateMap<Ram, RamListDto>();
            CreateMap<Ram, RamUpdateDto>();

            CreateMap<RamAddDto, Ram>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<RamUpdateDto, Ram>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion

            #region SSD Map
            CreateMap<SSD, SSDAddDto>();
            CreateMap<SSD, SSDDetailDto>();
            CreateMap<SSD, SSDListDto>();
            CreateMap<SSD, SSDUpdateDto>();

            CreateMap<SSDAddDto, SSD>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            CreateMap<SSDUpdateDto, SSD>()
                .ForMember(dest => dest.ImageList, opt => opt.Ignore());
            #endregion


        }
    }
}
