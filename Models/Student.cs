using System;
using System.Collections.Generic;

namespace WinFormsAppEos.Models
{
    public partial class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
        }

        public string Username { get; set; } = null!;
        public string? Password { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
