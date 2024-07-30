using System.Collections.Generic;
using RazorCRUD.Models;

namespace RazorCRUD.Data
{
    public static class StudentData
    {
        public static List<Student> Students { get; } = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", City = "New York" },
            new Student { Id = 2, Name = "Jane Smith", City = "Los Angeles" },
            new Student { Id = 3, Name = "Sam Brown", City = "Chicago" }
        };
    }
}
