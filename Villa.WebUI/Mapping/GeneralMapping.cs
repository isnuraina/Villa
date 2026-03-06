using AutoMapper;
using Villa.Dto.Dto.BannerDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultBannerDto,Banner>().ReverseMap(); 
            CreateMap<UpdateBannerDto,Banner>().ReverseMap(); 
            CreateMap<CreateBannerDto,Banner>().ReverseMap(); 

        }
    }
}
