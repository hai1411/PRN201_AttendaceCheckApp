using System;

namespace StudentManagementWebApp.Models
{
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; }
    }
}
