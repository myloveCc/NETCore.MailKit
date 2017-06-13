using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore.MailKit.Infrastructure
{
    public class MailKitOptionsBuilder
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
    }
}
