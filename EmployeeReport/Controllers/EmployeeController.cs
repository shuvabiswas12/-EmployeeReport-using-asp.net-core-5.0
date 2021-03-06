using EmployeeReport.DataContext;
using EmployeeReport.Models;
using EmployeeReport.Models.EmployeeViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeReport.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> employeeList = _db.Employees;
            return View(employeeList);
        }

        // httpGet - for getting update view
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            EmployeeVM EmployeeVm = new EmployeeVM
            {
                Employee = employee,
                PassingYearDropDown = GetYearDropDown(),
                CountryDropDown = GetCountryDropDown(),
                EducationDropdown = GetEducationDropDown(),
                BoardDropDown = GetBoardDropDown(),
                FacultyDropDown = GetFacultyDropDown(),
            };

            return View(EmployeeVm);
        }

        // actual updating operations are here
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateEmployee(EmployeeVM obj)
        {
            if (obj.profileImage != null)
            {
                obj.Employee.ProfilePicture = UploadImage(obj.profileImage);
            }
            
            _db.Employees.Update(obj.Employee);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var employee = _db.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                string path = @"C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\wwwroot\" + @"images\" + employee.ProfilePicture;
                if (System.IO.File.Exists(path))
                {
                    try
                    {
                        _db.Employees.Remove(employee);
                        _db.SaveChanges();
                        System.IO.File.Delete(path);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Problems on deleting file.");
                        Console.WriteLine(e.Message);
                    }

                    return RedirectToAction("Index");
                }

                return View("Index");
            }
        }

        // httpGet - view employee details in another page
        public IActionResult ViewEmployee(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // httpGet
        public IActionResult Create()
        {
            EmployeeVM EmployeeVm = new EmployeeVM
            {
                Employee = new Employee(),
                PassingYearDropDown = GetYearDropDown(),
                CountryDropDown = GetCountryDropDown(),
                EducationDropdown = GetEducationDropDown(),
                BoardDropDown = GetBoardDropDown(),
                FacultyDropDown = GetFacultyDropDown(),
            };

            return View(EmployeeVm);
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeVM obj)
        {
            Employee Employee = obj.Employee;

            if (obj.profileImage != null)
            {
                Employee.ProfilePicture = UploadImage(obj.profileImage);
            }
            else
            {
                Employee.ProfilePicture = "image.png";
            }

            Employee.Gender = obj.Gender;

            _db.Add(Employee);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        private IEnumerable<SelectListItem> GetYearDropDown()
        {
            List<SelectListItem> DropDownYears = new List<SelectListItem>();

            for (int i = 1990; i < 2040; i++)
            {
                DropDownYears.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            return DropDownYears;
        }

        private IEnumerable<SelectListItem> GetEducationDropDown()
        {
            IEnumerable<SelectListItem> EducationDropdown = new[]
            {
                new SelectListItem{Value = "SSC", Text = "SSC"},
                new SelectListItem{Value = "HSC", Text = "HSC"},
                new SelectListItem{Value = "BSC", Text = "BSC"},
            };
            return EducationDropdown;
        }

        private IEnumerable<SelectListItem> GetBoardDropDown()
        {
            IEnumerable<SelectListItem> BoardDropDown = new[]
            {
                new SelectListItem{Value = "Chittagong", Text = "Chittagong"},
                new SelectListItem{Value = "Dhaka", Text = "Dhaka"},
                new SelectListItem{Value = "Comilla", Text = "Comilla"},
                new SelectListItem{Value = "Jamalpur", Text = "Jamalpur"},
                new SelectListItem{Value = "Jessore", Text = "Jessore"},
                new SelectListItem{Value = "Coxbazar", Text = "Coxbazar"},
                new SelectListItem{Value = "Sylhet", Text = "Sylhet"},
            };
            return BoardDropDown;
        }

        private IEnumerable<SelectListItem> GetFacultyDropDown()
        {
            IEnumerable<SelectListItem> FacultyDropDown = new[]
            {
                    new SelectListItem{Value = "CSE", Text = "CSE"},
                    new SelectListItem{Value = "ME", Text = "ME"},
                    new SelectListItem{Value = "EEE", Text = "EEE"},
                    new SelectListItem{Value = "CSIT", Text = "CSIT"},
                    new SelectListItem{Value = "Science", Text = "Science"},
                    new SelectListItem{Value = "BBA", Text = "BBA"},
                    new SelectListItem{Value = "Pharmacy", Text = "Pharmacy"},
                };
            return FacultyDropDown;
        }

        private IEnumerable<SelectListItem> GetCountryDropDown()
        {
            IEnumerable<SelectListItem> CountryDropDown = new[]
            {
                new SelectListItem{Value = "Bangladesh".ToString(), Text="Bangladesh".ToString()},
                new SelectListItem{Value = "Canada".ToString(), Text="Canada".ToString()},
                new SelectListItem{Value = "India".ToString(), Text="India".ToString()},
                new SelectListItem{Value = "Australia".ToString(), Text="Australia".ToString()},
                new SelectListItem{Value = "Usa".ToString(), Text="Usa".ToString()},
                new SelectListItem{Value = "Nepal".ToString(), Text="Nepal".ToString()},
                new SelectListItem{Value = "Bhutan".ToString(), Text="Bhutan".ToString()},
                new SelectListItem{Value = "China".ToString(), Text="China".ToString()},
                new SelectListItem{Value = "Germany".ToString(), Text="Germany".ToString()},
                new SelectListItem{Value = "Finland".ToString(), Text="Finland".ToString()},
            };

            return CountryDropDown;
        }

        private String UploadImage(IFormFile files)
        {
            string newFileName = "";

            if (files != null)
            {
                if (files.Length > 0)
                {

                    Console.WriteLine("File Name = " + files);
                    Console.WriteLine("File Length = " + files.Length);

                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat(myUniqueFileName, fileExtension);

                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")).Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        files.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }

            return newFileName;
        }

    }
}
