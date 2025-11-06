using Blogy.Business.Mappings;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Blogy.Business.Services.CommentServices;
using Blogy.Business.Validators.CategoryValidators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Reflection;

namespace Blogy.Business.Extensions
{
    public static class ServerRegistrations
    {
        public static void AddServicesExt(this IServiceCollection services)
        {
            services.Scan(opt =>
            {
                opt.FromAssemblies(Assembly.GetExecutingAssembly())
                .AddClasses(publicOnly: false)
                .UsingRegistrationStrategy(registrationStrategy: RegistrationStrategy.Skip)
                .AsMatchingInterface()
                .AsImplementedInterfaces()
                .WithScopedLifetime();
            });

            services.AddAutoMapper(typeof(CategoryMappings).Assembly);
            services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssembly(typeof(CreateCategoryValidator).Assembly);
        }
    }
}
