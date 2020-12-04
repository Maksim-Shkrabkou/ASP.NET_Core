using ConvertingToMVC.Services;
using ConvertingToMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ConvertingToMVC.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoService _service;

        public ToDoController(ToDoService service)
        {
            _service = service;
        }
        
        // GET
        public ActionResult Category(string id)
        {
            var items = _service.GetItemsForCategory(id);
            var viewModel = new CategoryViewModel(items);

            return View(viewModel);
        }
    }
}