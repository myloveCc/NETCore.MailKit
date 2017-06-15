using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using NETCore.MailKit.Infrastructure.Internal;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NETCore.MailKit.Core;

namespace NETCore.MailKit.Infrastructure
{
    public class MailKitOptionsBuilder : IMailKitOptionsBuilder
    {
        /// <summary>
        /// Gets the service collection in which the interception based services are added.
        /// </summary>
        public IServiceCollection serviceCollection { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/> service collection</param>
        public MailKitOptionsBuilder(IServiceCollection services)
        {
            this.serviceCollection = services;
        }

        /// <summary>
        ///  add email service to di
        /// </summary>
        /// <param name="options"></param>
        /// <param name="lifetime"></param>
        /// <returns></returns>
        public IMailKitOptionsBuilder UseMailKit(MailKitOptions options, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            AddProviderService(options);
            serviceCollection.TryAdd(new ServiceDescriptor(typeof(IEmailService), typeof(EmailService), lifetime));
            return this;
        }

        private void AddProviderService(MailKitOptions options)
        {
            MailKitProvider provider = new MailKitProvider(options);
            serviceCollection.TryAddSingleton<IMailKitProvider>(provider);
        }
    }
}
