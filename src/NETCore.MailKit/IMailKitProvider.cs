using MailKit.Net.Smtp;
using NETCore.MailKit.Infrastructure.Internal;
using System;

namespace NETCore.MailKit
{
    public interface IMailKitProvider
    {
        /// <summary>
        /// mailkit options
        /// </summary>
        MailKitOptions Options { get; }

        /// <summary>
        /// smtp client
        /// </summary>
        SmtpClient Client { get; }
    }
}
