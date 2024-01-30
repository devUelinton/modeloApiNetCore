using AutoMapper;

namespace modeloAPI.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            /*
            CreateMap<ViewModelTeplate, CommandTemplate>()
                .ConstructUsing(c => new CommandTemplate());
            */
        }
    }
}

