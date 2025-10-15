using MimeKit;
using MimeKit.Text;
using NETCore.MailKit.Infrastructure.Internal;
using NETCore.MailKit.Shared;
using System.IO;
using System.Linq;
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
        /// <param name="sender">from</param>
        public void Send(string mailTo, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, null, null, subject, message, Encoding.UTF8, isHtml, sender);
        }

        /// <summary>
        /// send email
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="encoding">email message encoding</param>
        /// <param name="isHtml">is set message as html</param>
        /// <param name="sender">from</param>
        public void Send(string mailTo, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, null, null, subject, message, encoding, isHtml, sender);
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
        /// <param name="sender">from</param>
        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, mailCc, mailBcc, subject, message, Encoding.UTF8, isHtml, sender);
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
        /// <param name="sender">from</param>
        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, mailCc, mailBcc, subject, message, encoding, isHtml, sender);
        }

        public void Send(string mailTo, string subject, string message, string[] attachments, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, null, null, subject, message, Encoding.UTF8, isHtml, sender, attachments);
        }

        public void Send(string mailTo, string subject, string message, string[] attachments, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, null, null, subject, message, encoding, isHtml, sender, attachments);
        }

        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, string[] attachments, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, mailCc, mailBcc, subject, message, Encoding.UTF8, isHtml, sender, attachments);
        }

        public void Send(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, string[] attachments, bool isHtml = false, SenderInfo sender = null)
        {
            SendEmail(mailTo, mailCc, mailBcc, subject, message, encoding, isHtml, sender, attachments);
        }

        /// <summary>
        /// send email with UTF-8 async
        /// </summary>
        /// <param name="mailTo">consignee email,multi split with ","</param>
        /// <param name="subject">subject</param>
        /// <param name="message">email message</param>
        /// <param name="isHtml">is set message as html</param>
        /// <param name="sender">from</param>
        public Task SendAsync(string mailTo, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, null, null, subject, message, Encoding.UTF8, isHtml, sender);
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
        /// <param name="sender">from</param>
        public Task SendAsync(string mailTo, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, null, null, subject, message, encoding, isHtml, sender);
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
        /// <param name="sender">from</param>
        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, mailCc, mailBcc, subject, message, Encoding.UTF8, isHtml, sender);
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
        /// <param name="sender">from</param>
        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, mailCc, mailBcc, subject, message, encoding, isHtml, sender);
            });
        }

        public Task SendAsync(string mailTo, string subject, string message, string[] attachments, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, null, null, subject, message, Encoding.UTF8, isHtml, sender, attachments);
            });
        }

        public Task SendAsync(string mailTo, string subject, string message, string[] attachments, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, null, null, subject, message, encoding, isHtml, sender, attachments);
            });
        }

        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, string[] attachments, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, mailCc, mailBcc, subject, message, Encoding.UTF8, isHtml, sender, attachments);
            });
        }

        public Task SendAsync(string mailTo, string mailCc, string mailBcc, string subject, string message, string[] attachments, Encoding encoding, bool isHtml = false, SenderInfo sender = null)
        {
            return Task.Factory.StartNew(() =>
            {
                SendEmail(mailTo, mailCc, mailBcc, subject, message, encoding, isHtml, sender, attachments);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mailTo"></param>
        /// <param name="mailCc"></param>
        /// <param name="mailBcc"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="encoding"></param>
        /// <param name="isHtml"></param>
        /// <param name="sender">from</param>
        private void SendEmail(string mailTo, string mailCc, string mailBcc, string subject, string message, Encoding encoding, bool isHtml, SenderInfo sender = null, string[] attachments = default)
        {
            var _to = new string[0];
            var _cc = new string[0];
            var _bcc = new string[0];
            if (!string.IsNullOrEmpty(mailTo))
                _to = mailTo.Split(',').Select(x => x.Trim()).ToArray();
            if (!string.IsNullOrEmpty(mailCc))
                _cc = mailCc.Split(',').Select(x => x.Trim()).ToArray();
            if (!string.IsNullOrEmpty(mailBcc))
                _bcc = mailBcc.Split(',').Select(x => x.Trim()).ToArray();

            Check.Argument.IsNotEmpty(_to, nameof(mailTo));
            Check.Argument.IsNotEmpty(message, nameof(message));

            using var mimeMessage = new MimeMessage();

            //add mail from
            if (!string.IsNullOrEmpty(sender?.SenderEmail) && !string.IsNullOrEmpty(sender?.SenderName))
            {
                mimeMessage.From.Add(new MailboxAddress(sender.SenderName, sender.SenderEmail));
            }
            else
            {
                mimeMessage.From.Add(new MailboxAddress(_MailKitProvider.Options.SenderName, _MailKitProvider.Options.SenderEmail));
            }

            //add mail to 
            foreach (var to in _to)
            {
                mimeMessage.To.Add(MailboxAddress.Parse(to));
            }

            //add mail cc
            foreach (var cc in _cc)
            {
                mimeMessage.Cc.Add(MailboxAddress.Parse(cc));
            }

            //add mail bcc 
            foreach (var bcc in _bcc)
            {
                mimeMessage.Bcc.Add(MailboxAddress.Parse(bcc));
            }

            //add subject
            mimeMessage.Subject = subject;

            //add email body
            TextPart body = null;

            if (isHtml)
            {
                body = new TextPart(TextFormat.Html);
            }
            else
            {
                body = new TextPart(TextFormat.Text);
            }
            //set email encoding
            body.SetText(encoding, message);

            //add multipart
            Multipart multipartBody = new Multipart("mixed")
            {
                body
            };

            // add attachments
            if (attachments != null)
                foreach (var attach in attachments)
                {
                    var mimeType = MimeTypes.GetMimeType(attach).Split('/');
                    multipartBody.Add(new MimePart(mimeType[0], mimeType[1])
                    {
                        IsAttachment = true,
                        Content = new MimeContent(File.Open(attach, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete), ContentEncoding.Default),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(attach),
                    });
                }

            //set email body
            mimeMessage.Body = multipartBody;

            using var client = _MailKitProvider.SmtpClient;
            client.Send(mimeMessage);
        }
    }
}
