using AutoMapper;
using GEN_InventarioRestApi.DTO;
using GEN_InventarioRestApi.Modelos;

namespace GEN_InventarioRestApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Seccion, SeccionDto>().ReverseMap();
            //CreateMap<SeccionDto, Seccion>();
        }
    }
}
