using MailKit.Net.Smtp;
using System;

namespace NETCore.MailKit
{
    public interface IMailKitProvider
    {
        /// <summary>
        /// smtp client
        /// </summary>
        SmtpClient Client { get; }
    }
}
