using AutoMapper;

namespace API_BLAZOR_
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile() 
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}
