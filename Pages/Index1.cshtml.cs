using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectLibX.Models;

namespace ProjectLibX.Pages
{
    [BindProperties]
    public class Index1Model : PageModel
    {
        private readonly StudentContext _dbcontext;

        public Student Student { get; set; }         
        public Index1Model(StudentContext Dbcontext)
        {
            _dbcontext = Dbcontext;
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                    _dbcontext.Students.Add(Student);
                _dbcontext.SaveChanges();
                    return RedirectToPage("Notify");
           }
            return Page();  

        }

    }    
    }

