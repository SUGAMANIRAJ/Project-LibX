using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectLibX.Models;

namespace ProjectLibX.Pages
{
    public class ActionsModel : PageModel
    {
        private readonly StudentContext _dbcontext;
        public Student Student { get; set; }
        public ActionsModel(StudentContext DbContext)
        {
            _dbcontext = DbContext;
        }

        public void OnGet(int id)
        {
            Student = _dbcontext.Students.FirstOrDefault(x => x.ID == id);
           
        }
     


    }
}
