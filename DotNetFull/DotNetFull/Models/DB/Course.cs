using System;
using System.Collections.Generic;

namespace DotNetFull.Models.DB
{
    public partial class Course
    {
        public int İd { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Durum { get; set; }
    }
}
