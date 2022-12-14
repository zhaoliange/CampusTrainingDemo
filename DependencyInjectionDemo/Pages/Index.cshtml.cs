using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjectionDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMyDependency _myDependency;

        public IndexModel(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }

        public void OnGet()
        {
            _myDependency.WriteMessage("IndexModel.OnGet");
        }
    }
}