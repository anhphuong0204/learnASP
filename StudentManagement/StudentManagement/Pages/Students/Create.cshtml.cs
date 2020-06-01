using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentManagement.Data.SchoolContext _context;

        public CreateModel(StudentManagement.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Student emptyStu = new Student();
            if (await TryUpdateModelAsync<Student>(emptyStu, "student", s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
            {
                _context.Students.Add(emptyStu);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
