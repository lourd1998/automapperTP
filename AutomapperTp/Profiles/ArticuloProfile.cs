using AutoMapper;
using AutomapperTp.Models;

namespace AutomapperTp.Profiles
{
    public class ArticuloProfile : Profile
    {
        public ArticuloProfile()
        {
            CreateMap<ArticuloDto, ArticuloViewModel>();
        }
    }
}
