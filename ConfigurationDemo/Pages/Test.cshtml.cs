using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ConfigurationDemo.Pages
{
    public class TestModel : PageModel
    {
        private readonly PositionOptions _options;

        public TestModel(IOptions<PositionOptions> options)
        {
            _options = options.Value;
        }

        public ContentResult OnGet()
        {
            return Content($"Title: {_options.Title} \n" +
                           $"Name: {_options.Name}");
        }
    }
}
