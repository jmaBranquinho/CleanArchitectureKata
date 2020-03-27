using AutoMapper;

namespace CleanArch.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new ViewModelToDomainProfile());
                configuration.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
