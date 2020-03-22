using AutoMapper;

namespace CleanArch.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMapping()
        {
               return new MapperConfiguration(cfg =>
               {
                   cfg.AddProfile(new ViewModelToDomainProfile());
                   cfg.AddProfile(new DomainToViewModel());
               });
        }
    }
}