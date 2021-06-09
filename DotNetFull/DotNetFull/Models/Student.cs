using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFull.Models
{
    public class Student
    {
        public string  Name { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Kursa katılığ katılmayacağınızı  belirtiniz")]
        public bool? WillAttend { get; set; }
    }
}
