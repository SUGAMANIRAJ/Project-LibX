using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectLibX.Models;

namespace ProjectLibX.Pages
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        public Student Student { get; set; }

        private readonly StudentContext _dbcontext;
        public DeleteModel(StudentContext DbContext)
        {
            _dbcontext = DbContext; 
        }
        public void OnGet(int id)
        {
           Student= _dbcontext.Students.FirstOrDefault(x=>x.ID==id);

        }
        public async Task<ActionResult> OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                

                _dbcontext.Students.Update(Student);
                _dbcontext.SaveChanges();
                return RedirectToPage("NotifyReturn");
            }
            return Page();
        }
    }
}
