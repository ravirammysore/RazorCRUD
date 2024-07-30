using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCRUD.Data;
using RazorCRUD.Models;

namespace RazorCRUD.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Student.Id = StudentData.Students.Count + 1;
            StudentData.Students.Add(Student);

            return RedirectToPage("/Index");
        }
    }
}
