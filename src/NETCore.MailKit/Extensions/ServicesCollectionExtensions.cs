using Microsoft.Extensions.DependencyInjection;
using NETCore.MailKit.Infrastructure;
using NETCore.MailKit.Infrastructure.Internal;
using NETCore.MailKit.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore.MailKit.Extensions
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddMailKit(this IServiceCollection serviceCollection, Action<MailKitOptionsBuilder> optionsAction)
        {
            Check.Argument.IsNotNull(serviceCollection, nameof(serviceCollection), "IServiceCollection is not dependency injection");
            Check.Argument.IsNotNull(optionsAction, nameof(optionsAction));

            optionsAction.Invoke(new MailKitOptionsBuilder(serviceCollection));

            return serviceCollection;
        }
    }
}
