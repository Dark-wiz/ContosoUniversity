﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUni.Models 
{
    public class Instructor : Person
    {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        

        //public ICollection<CourseAssignment> CourseAssignments { get; set; }
        private ICollection<CourseAssignment> _courseAssignments;
        public ICollection<CourseAssignment> CourseAssignments
        {
            get
            {
                return _courseAssignments ?? (_courseAssignments = new List<CourseAssignment>());
            }
            set
            {
                _courseAssignments = value;
            }
        }

        public OfficeAssignment OfficeAssignment { get; set; }

    }
}
