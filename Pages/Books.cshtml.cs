using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectLibX.Models;

namespace ProjectLibX.Pages
{
    [BindProperties]
    public class BooksModel : PageModel
    {
        private readonly StudentContext _dbcontext;
        public Student Student { get; set; }
        public BooksModel(StudentContext DbContext)
        {
            _dbcontext= DbContext;    
        }

        public void OnGet(int id)
        {
            Student = _dbcontext.Students.FirstOrDefault(x=>x.ID==id);
        }
    }
}
