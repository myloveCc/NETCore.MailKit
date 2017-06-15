using Microsoft.Extensions.DependencyInjection;
using NETCore.MailKit.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore.MailKit.Infrastructure
{
    public interface IMailKitOptionsBuilder
    {
        /// <summary>
        /// service collection
        /// </summary>
        IServiceCollection serviceCollection { get; }

        /// <summary>
        /// get redis options and add ConnectionMultiplexer to sercice collection
        /// </summary>
        /// <param name="options">redis options</param>
        /// <param name="lifetime"></param>
        /// <returns></returns>
        IMailKitOptionsBuilder UseMailKit(MailKitOptions options, ServiceLifetime lifetime = ServiceLifetime.Scoped);
    }
}
