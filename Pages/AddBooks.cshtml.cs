using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using ProjectLibX.Models;
using System.Reflection.Metadata.Ecma335;

namespace ProjectLibX.Pages
{
    [BindProperties]
    public class AddBooksModel : PageModel
    {
       

        private readonly StudentContext _dbContext;
       
        public AddBooksModel(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Student Student { get; set; }

        public void OnGet(int id)
        {
            Student = _dbContext.Students.FirstOrDefault(x => x.ID == id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _dbContext.Students.Update(Student);
                _dbContext.SaveChanges();
                return RedirectToPage("NotifyIssue");
            }
            return Page();
        }
      

     
    }

}
