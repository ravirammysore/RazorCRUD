using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCRUD.Data;
using RazorCRUD.Models;
using System.Collections.Generic;

namespace RazorCRUD.Pages
{
    public class IndexModel : PageModel
    {
        public List<Student> Students { get; private set; }

        public void OnGet()
        {
            Students = StudentData.Students;
        }
    }
}
