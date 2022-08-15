using Microsoft.AspNetCore.Mvc;

namespace FormatWebApiResponseDataDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[FormatFilter]
    //[Produces("application/json")]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoItemStore _todoItemStore;
        public TodoItemsController(TodoItemStore todoItemStore)
            => _todoItemStore = todoItemStore;

        [HttpGet("Error")]
        public IActionResult GetError()=> Problem("Something went wrong.");

        [HttpGet]
        public IActionResult Get()=> Ok(_todoItemStore.GetList());

        [Produces("application/json")]
        [HttpGet("GetList")]
        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _todoItemStore.GetList();
        }

        [HttpGet("Version")]
        public ContentResult GetVersion()
            => Content("v1.0.0");

        [HttpGet("{id:long}")]
        public IActionResult GetById(long id)
        {
            var todo = _todoItemStore.GetById(id);

            if (todo is null)
            {
                return NotFound();
            }

            return Ok(todo);
        }
        /*
        [HttpGet("{id:long}.{format?}")]
        public TodoItem? GetById(long id) => _todoItemStore.GetById(id);
        */
        [HttpPost("Sample")]
        public IActionResult PostSample(SampleModel model)
        {
            return Ok(model);
        }
    }
}