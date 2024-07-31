using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCRUD.Data;
using RazorCRUD.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorCRUD.Pages
{
    public class IndexModel : PageModel
    {
        private readonly StudentDemoContext _context;

        //Dependency Injection (runtime)
        public IndexModel(StudentDemoContext context)
        {            
            _context = context;
        }

        public IList<Student> Students { get; set; }

        public async Task OnGetAsync()
        {
            //there is no sql per say
            //behind the scenes EF creats the SQL
            //select * from Students
            Students = await _context.Students.ToListAsync();
        }
    }
}
