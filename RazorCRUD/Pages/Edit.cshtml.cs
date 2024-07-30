using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCRUD.Data;
using RazorCRUD.Models;
using System.Linq;

namespace RazorCRUD.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty] //attributes
        public Student Student { get; set; }

        public IActionResult OnGet(int id)
        {
            //LINQ query (Data_Streams)
            //Query/filtering any collection
            Student = StudentData.Students.FirstOrDefault(s => s.Id == id);

            if (Student == null)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //LINQ
            var studentInList = StudentData.Students.FirstOrDefault(s => s.Id == Student.Id);

            if (studentInList == null)
            {
                return RedirectToPage("/Index");
            }

            studentInList.Name = Student.Name;
            studentInList.City = Student.City;

            return RedirectToPage("/Index");
        }
    }
}
