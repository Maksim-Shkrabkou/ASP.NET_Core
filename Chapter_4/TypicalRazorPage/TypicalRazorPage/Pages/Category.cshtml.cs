using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TypicalRazorPage.Models;
using TypicalRazorPage.Services;

namespace TypicalRazorPage.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ToDoService _service;
        public List<ToDoListModel> Items { get; set; }

        public CategoryModel(ToDoService service)
        {
            _service = service;
        }

        public ActionResult OnGet(string category)
        {
            Items = _service.GetItemsForCategory(category);
            
            return Page();
        }
    }
}