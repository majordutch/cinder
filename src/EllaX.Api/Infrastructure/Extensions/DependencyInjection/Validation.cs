﻿using EllaX.Application.Behaviors;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace EllaX.Extensions.DependencyInjection
{
    public static class Validation
    {
        public static IMvcBuilder AddValidation(this IMvcBuilder builder)
        {
            return builder.ConfigureApiBehaviorOptions(opt => { opt.SuppressModelStateInvalidFilter = true; })
                .AddFluentValidation(configuration =>
                    configuration.RegisterValidatorsFromAssemblyContaining(typeof(RequestValidationBehavior<,>)));
        }
    }
}
