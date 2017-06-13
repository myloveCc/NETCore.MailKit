using System;
using Xunit;
using NETCore.MailKit.Core;
using System.Linq;

namespace NETCore.MailKit.Tests
{
    public class MailKitTests
    {
        private readonly IEmailService _EmailService;

        public MailKitTests()
        {
            _EmailService = new EmailService();
        }

        [Fact]
        public void Test1()
        {
           
        }
    }
}
