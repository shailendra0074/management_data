using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using schoolmanagementsys.Data;
using schoolmanagementsys.Models;
using System.Collections.Generic;
using System.Linq;

namespace schoolmanagementsys.Pages
{
    public class TestDbModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public TestDbModel(SchoolDbContext context)
        {
            _context = context;
        }
        public IList<Student> Student { get; set; }
        public void OnGet()
        {
            Student = _context.Student.ToList();
        }
    }
}
