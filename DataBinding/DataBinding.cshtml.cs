using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DataBinding.Pages
{
    public class DataBindingModel : PageModel
    {
        [BindProperty]
        public Person Person { get; set; }
        public static List<Person> People { get; } = new List<Person>();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Person != null)
            {
             
            }
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public int id { get; set; }
    }
}
