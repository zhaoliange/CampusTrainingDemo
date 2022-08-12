using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersDemo
{
    public class SampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            Console.WriteLine($"- {nameof(SampleActionFilter)}.{nameof(OnActionExecuting)}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            Console.WriteLine($"- {nameof(SampleActionFilter)}.{nameof(OnActionExecuted)}");
        }
    }
}
