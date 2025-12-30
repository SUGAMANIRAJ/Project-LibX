using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectLibX.Models;

namespace ProjectLibX.Pages
{
    [BindProperties]
    public class LibXLibraryModel : PageModel
    {
        private readonly StudentContext _dbcontext;

      

        public LibXLibraryModel(StudentContext DbContext)
        {
            _dbcontext = DbContext;    
        }
        
        public IEnumerable<Student> Students { get; set; }
        public void OnGet()
        {
            Students = _dbcontext.Students.ToList();
        }
    }
}
