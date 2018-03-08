using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CorgiDev.StaffDirectoryProject.Models
{
    public class Entry
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Entry()
        {
        }

        /// <summary>
        /// Constructor for easily creating entries.
        /// </summary>
        /// <param name="id">The ID for the entry.</param>
        /// <param name="employeeId">The employee ID for the entry.</param>
        /// <param name="firstName">The first name for the entry.</param>
        /// <param name="lastName">The last name for the entry month.</param>
        /// <param name="jobTitle">The job title for the entry.</param>
        /// <param name="departmentName">The department name for the entry.</param>
        /// <param name="phoneNumber">The phone number for the entry.</param>
        /// <param name="emailAddress">The email address for the entry.</param>
        /// <param name="skillType">The skill type for the entry.</param>
        /// <param name="notes">The notes for the entry.</param>

        public Entry(int id, int employeeId, string firstName, string lastName, string jobTitle, Department.DepartmentName departmentName, 
            string phoneNumber, string emailAddress, Skill.SkillType skillType, string notes = null)
        {
            Id = id;
            EmployeeId = (int)employeeId;
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            DepartmentId = (int)departmentName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            SkillId = (int)skillType;
            Notes = notes;
        }

        /// <summary>
        /// The ID of the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The employee ID of the entry.
        /// </summary>
        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "Employee ID Required. This is their time clock number.")]
        [RegularExpression(@"/^[0-9]*$/", ErrorMessage = "Employee ID may only contain numbers.")]
        public int EmployeeId { get; set; }

        /// <summary>
        /// The First Name of the entry.
        /// </summary>
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Last Name of the entry.
        /// </summary>
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        /// <summary>
        /// The Job Title of the entry.
        /// </summary>
        [Display(Name = "Job Title")]
        [Required(ErrorMessage = "Job Title Required")]
        public string JobTitle { get; set; }

        /// <summary>
        /// The department ID for the entry. The ID value should map to an ID in the departments collection.
        /// </summary>
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The Department for the entry.
        /// </summary>
        [Required(ErrorMessage = "Department Required")]
        public Department Department { get; set; }

        /// <summary>
        /// The Phone Number of the entry.
        /// Checks for correct format.
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$" , ErrorMessage = "Entered phone format is not valid. Must be in format of ###-###-####.")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The Email Address of the entry.
        /// </summary>
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Email Address not in proper format.")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The skill ID for the entry. The ID value should map to an ID in the skills collection.
        /// </summary>
        [Display(Name = "Skill")]
        public int SkillId { get; set; }

        /// <summary>
        /// The skill for the entry.
        /// </summary>
        [Required(ErrorMessage = "Skill Required")]
        public Skill Skill { get; set; }

        /// <summary>
        /// The notes for the entry.
        /// </summary>
        [MaxLength(200, ErrorMessage = "The notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }
    }
}