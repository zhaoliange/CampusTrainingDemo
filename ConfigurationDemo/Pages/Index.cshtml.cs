using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ConfigurationDemo.Pages
{
    // requires using Microsoft.Extensions.Configuration;
    public class IndexModel : PageModel
    {
        // requires using Microsoft.Extensions.Configuration;
        private readonly IConfiguration Configuration;
        public PositionOptions? positionOptions { get; private set; }

        public IndexModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ContentResult OnGet()
        {
            var myKeyValue = Configuration["MyKey"];
            var title = Configuration["Position:Title"];
            var name = Configuration["Position:Name"];
            var defaultLogLevel = Configuration["Logging:LogLevel:Default"];


            return Content($"MyKey value: {myKeyValue} \n" +
                           $"Title: {title} \n" +
                           $"Name: {name} \n" +
                           $"Default Log Level: {defaultLogLevel}");
        }

        public ContentResult OnGet2()
        {
            var positionOptions = new PositionOptions();
            Configuration.GetSection(PositionOptions.Position).Bind(positionOptions);

            return Content($"Title: {positionOptions.Title} \n" +
                           $"Name: {positionOptions.Name}");
        }

        public ContentResult OnGet3()
        {
            positionOptions = Configuration.GetSection(PositionOptions.Position)
                                                         .Get<PositionOptions>();

            return Content($"Title: {positionOptions.Title} \n" +
                           $"Name: {positionOptions.Name}");
        }
    }
}
