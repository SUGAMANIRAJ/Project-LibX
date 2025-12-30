using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Numerics;

namespace ProjectLibX.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public  string RegNo { get; set; }
        [Required]
        public string Name_of_the_Student { get; set; }
        [Required]
        public int SEM { get; set; }
        [Required]
        public ulong ContInfo { get; set; }
        [Required]
        public string Email { get; set; }

       
        
        
        public string Book1 { get; set; }

        public string Book2 { get; set; }
        public string Book3 { get; set; }

        public string Book4 { get; set; }

        public string Book5 { get; set; }

    }
}
