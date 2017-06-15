using Microsoft.Extensions.DependencyInjection;
using NETCore.MailKit.Infrastructure;
using NETCore.MailKit.Infrastructure.Internal;
using NETCore.MailKit.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore.MailKit.Extensions
{
    public static class MailKitOptionsBuilderExtension
    {
        public static IMailKitOptionsBuilder UseMailKit(IMailKitOptionsBuilder builder, MailKitOptions options, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            Check.Argument.IsNotNull(builder, nameof(builder), "The MailKitOptionsBuilder is null");
            Check.Argument.IsNotNull(options, nameof(options), "The MailKitOptions is null");

            return builder.UseMailKit(options, lifetime);
        }
    }
}
