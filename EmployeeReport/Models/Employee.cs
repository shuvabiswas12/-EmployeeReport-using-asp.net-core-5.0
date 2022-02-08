using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeReport.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        // this is a radio  button
        [Required]
        public string Gender { get; set; }

        // this is a dropdown of select tag in html
        [Required]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        // this is an image
        [Required]
        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }

        // this is a dropdown 
        [Required]
        [Display(Name = "SSC Passing Year")]
        public string SscPassingYear { get; set; }

        // this is a dropdown 
        [Required]
        [Display(Name = "HSC Passing Year")]
        public string HscPassingYear { get; set; }

        // this is a dropdown 
        [Required]
        [Display(Name = "Graduation Year")]        
        public string GraduationYear { get; set; }

        [Required]
        [Display(Name = "SSC's Grade")]
        public double SscGrade { get; set; }

        [Required]
        [Display(Name = "HSC's Grade")]
        public double HscGrade { get; set; }

        [Required]
        [Display(Name = "Bechelor's Grade")]
        public double BechelorGrade { get; set; }

        [Required]
        public string NID { get; set; }

        [Required]
        [Display(Name = "School")]
        public string SchoolName { get; set; }

        [Required]
        [Display(Name = "SSC Board")]
        public string SscBoard { get; set; }

        [Required]
        [Display(Name = "College")]
        public string CollegeName { get; set; }

        [Required]
        [Display(Name = "HSC Board")]
        public string HscBoard { get; set; }

        [Required]
        [Display(Name = "University")]
        public string UniversityName { get; set; }

        [Required]        
        [Display(Name="Faculty Name")]
        public string FacultyName { get; set; }

        [Required]
        [Display(Name="Mailing Address")]
        public string MailingAddress { get; set; }
    }
}
