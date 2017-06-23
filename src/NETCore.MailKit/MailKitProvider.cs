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
        public MailKitOptions Options { get; private set; }

        public MailKitProvider(MailKitOptions mailKitOptions)
        {
            Options = mailKitOptions;
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
            if (!Options.SSL)
            {
                client.Connect(Options.Server, Options.Port, SecureSocketOptions.None);
            }
            else
            {
                client.Connect(Options.Server, Options.Port, SecureSocketOptions.SslOnConnect);
            }

            // Note: since we don't have an OAuth2 token, disable
            // the XOAUTH2 authentication mechanism.
            client.AuthenticationMechanisms.Remove("XOAUTH2");
            // user login smtp server
            client.Authenticate(Options.Account, Options.Password);

            return client;
        }
    }
}
