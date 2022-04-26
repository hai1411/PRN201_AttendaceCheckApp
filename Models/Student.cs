using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementWebApp.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; }
    }
}
