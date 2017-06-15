using NETCore.MailKit.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace NETCore.MailKit
{
    public class MailKitProvider : IMailKitProvider
    {
        public readonly MailKitOptions _MailKitOptions;

        public MailKitProvider(MailKitOptions mailKitOptions)
        {
            _MailKitOptions = mailKitOptions;
        }

        public SmtpClient Client
        {
            get
            {
                return lazySmtpClient().Value;
            }
        }


        private Lazy<SmtpClient> lazySmtpClient()
        {
            return new Lazy<SmtpClient>(() =>
            {
                return InitSmtpClient();
            });
        }

        private SmtpClient InitSmtpClient()
        {
            var client = new SmtpClient();
            if (_MailKitOptions.SSL)
            {
                client.Connect(_MailKitOptions.Server, _MailKitOptions.Port, SecureSocketOptions.None);
            }
            else
            {
                client.Connect(_MailKitOptions.Server, _MailKitOptions.Port, SecureSocketOptions.SslOnConnect);
            }

            return client;
        }
    }
}
