using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeReport.Models.EmployeeViewModel
{
    public class EmployeeVM
    {
        public Employee Employee { get; set; }
        
        [Required]
        public string Gender { get; set; }

        [Required]
        public IFormFile profileImage { get; set; }

        public IEnumerable<SelectListItem> PassingYearDropDown { get; set; }

        public IEnumerable<SelectListItem> CountryDropDown { get; set; }

        public IEnumerable<SelectListItem> EducationDropdown { get; set; }

        public IEnumerable<SelectListItem> BoardDropDown { get; set; }

        public IEnumerable<SelectListItem> FacultyDropDown { get; set; }
    }
}
