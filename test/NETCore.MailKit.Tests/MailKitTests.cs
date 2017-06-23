using System;
using Xunit;
using NETCore.MailKit.Core;
using System.Linq;
using NETCore.MailKit.Infrastructure.Internal;

namespace NETCore.MailKit.Tests
{
    public class MailKitTests
    {
        private readonly IEmailService _EmailService;
        private readonly string _MailToOne;
        private readonly string _MailToMulti;

        public MailKitTests()
        {
            var provider = new MailKitProvider(new MailKitOptions()
            {
                Server = "smtp server address",
                Port = 25,
                SenderName = "mail from user name",
                SenderEmail = "mail from ",
                Account = "your email",
                Password = "your password"
            });

            _EmailService = new EmailService(provider);

            _MailToOne = "email address";
            _MailToMulti = "address1,address2";
        }

        [Fact(DisplayName = "MailToisNullTest")]
        public void Send_Email_WithNoMailTo_Test()
        {
            //Act
            var excetpion = Record.Exception(() => _EmailService.Send("", "Test MailKit Extensions", "Hello MailKit"));

            //Assert
            Assert.IsType<ArgumentException>(excetpion);
            Assert.Equal("collection not be empty.\r\nParameter name: mailTo", excetpion.Message);
        }

        [Fact(DisplayName = "MailToOneTest")]
        public void Send_Email_ToOne_Test()
        {
            _EmailService.Send(_MailToOne, "Test MailKit Extensions", "Hello MailKit");
        }

        [Fact(DisplayName = "MailToMultiTest")]
        public void Send_Email_ToMulti_Test()
        {
            _EmailService.Send(_MailToMulti, "Test MailKit Extensions", "Hello MailKit");
        }

        [Fact(DisplayName = "MailHtmlBodyTest")]
        public void Send_Email_Hmtl_Test()
        {
            _EmailService.Send(_MailToOne, "Test MailKit Extensions Html Body", "<html><h1>Hello MailKit<h1><br/><p style='font-size:18px;color:red'>Font size is 18px ,color is red</p></html>", true);
        }
    }
}
