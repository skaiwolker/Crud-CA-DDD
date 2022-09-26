using CleanArch.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanArch.MVC3.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappinpProfile));
        }
    }
}
