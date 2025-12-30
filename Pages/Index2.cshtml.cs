using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectLibX.Models;

namespace ProjectLibX.Pages
{
    [BindProperties]
    public class Index2Model : PageModel
    {
        private readonly StudentContext _dbcontext;

        public IEnumerable<Student> Students;

        public Index2Model(StudentContext DbContext)
        {
            _dbcontext = DbContext;
        }
        public void OnGet()
        {
            Students = _dbcontext.Students.ToList();
        }
    }
}
