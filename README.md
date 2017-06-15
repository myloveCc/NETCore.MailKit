# NETCore.MailKit
[MailKit](https://github.com/jstedfast/MailKit) extension for asp.net core

# Install with nuget

```
Install-Package NETCore.MailKit
```

# How to use

## Add MailKit in startup like 

```csharp

public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddMvc();

    //Add MailKit
    services.AddMailKit(optionBuilder =>
    {
        optionBuilder.UseMailKit(new MailKitOptions()
        {
            //get options from sercets.json
            Server = Configuration["Server"],
            Port = Convert.ToInt32(Configuration["Port"]),
            SenderName = Configuration["SenderName"],
            SenderEmail = Configuration["SenderEmail"],
            Account = Configuration["Account"],
            Passord = Configuration["Passord"]
        });
    });
}

```

## Use EmailService like 

```csharp
public class HomeController : Controller
{
    private readonly IEmailService _EmailService;

    public HomeController(IEmailService emailService)
    {
        _EmailService = emailService;
    }

    public IActionResult Email()
    {
        ViewData["Message"] = "ASP.NET Core mvc send email example";

        _EmailService.Send("xxxx@gmail.com", "ASP.NET Core mvc send email example", "Send from asp.net core mvc action");

        return View();
    }
}

```

# LICENSE

MIT
