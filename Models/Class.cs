using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentManagementWebApp.Models
{
    public partial class Class
    {
        private int ClassId { get; set; }

        private Teacher ClassTeacher { get; set; }

        private List<Student> ListOfStudent{get; set;}
    }
}
