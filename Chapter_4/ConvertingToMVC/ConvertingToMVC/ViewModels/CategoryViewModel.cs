using System.Collections.Generic;
using ConvertingToMVC.Models;

namespace ConvertingToMVC.ViewModels
{
    public class CategoryViewModel
    {
        public List<ToDoListModel> Items { get; set; }

        public CategoryViewModel(List<ToDoListModel> items)
        {
            Items = items;
        }
    }
}