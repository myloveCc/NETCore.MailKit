using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NETCore.MailKit.Core
{
    public class EmailService : IEmailService
    {
        private readonly IMailKitProvider _MailKitProvider;

        public EmailService(IMailKitProvider provider)
        {
            _MailKitProvider = provider;
        }

        /// <summary>
        /// send email with UTF-8
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="isHtml">is set message as html</param>
        public void Send(string mailTo, string subject, string message, bool isHtml = false)
        {
            using (var client = _MailKitProvider.Client)
            {

            }
        }


        /// <summary>
        /// send email
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="encoding">email message encoding</param>
        /// <param name="isHtml">is set message as html</param>
        public void Send(string mailTo, string subject, string message, Encoding encoding, bool isHtml = false)
        {
            using (var client = _MailKitProvider.Client)
            {

            }
        }

        /// <summary>
        /// send email with UTF-8
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="mailCc">send cc,multi split with ","</param>
        /// <param name="mailBcc">send bcc,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="isHtml">is set message as html</param>
        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, bool isHtml = false)
        {
            using (var client = _MailKitProvider.Client)
            {

            }
        }

        /// <summary>
        /// send email
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="mailCc">send cc,multi split with ","</param>
        /// <param name="mailBcc">send bcc,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="encoding">email message encoding</param>
        /// <param name="isHtml">is set message as html</param>
        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml = false)
        {
            using (var client = _MailKitProvider.Client)
            {

            }
        }


        /// <summary>
        /// send email with UTF-8 async
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="isHtml">is set message as html</param>
        public Task SendAsync(string mailTo, string subject, string message, bool isHtml = false)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var client = _MailKitProvider.Client)
                {

                }
            });
        }

        /// <summary>
        /// send email async
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="encoding">email message encoding</param>
        /// <param name="isHtml">is set message as html</param>

        public Task SendAsync(string mailTo, string subject, string message, Encoding encoding, bool isHtml = false)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var client = _MailKitProvider.Client)
                {

                }
            });
        }

        /// <summary>
        /// send email with UTF-8 async
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="mailCc">send cc,multi split with ","</param>
        /// <param name="mailBcc">send bcc,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="isHtml">is set message as html</param>
        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, bool isHtml = false)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var client = _MailKitProvider.Client)
                {

                }
            });
        }

        /// <summary>
        /// send email async
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="mailCc">send cc,multi split with ","</param>
        /// <param name="mailBcc">send bcc,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="encoding">email message encoding</param>
        /// <param name="isHtml">is set message as html</param>
        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml = false)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var client = _MailKitProvider.Client)
                {

                }
            });
        }
    }
}