using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorgiDev.StaffDirectoryProject.Models
{
    public class Department
    {
        public enum DepartmentName
        {
            Executive = 1,
            CTS = 2,
            TPR = 3,
            BrailleProduction = 4,
            ATT = 5,
            GraphicProduction = 6,
            EducationalAides = 7,
            Engineering = 8,
            BrailleProofreading = 9,
            BrailleTranscription = 10,
            Planning = 11,
            FieldServices = 12,
            ResourceServices = 13,
            Shipping = 14,
            EducationalProductResearch = 15,
            MarketingAndSales = 16
        }

        /// <summary>
        /// Constructors a department for the provided department name and name.
        /// </summary>
        /// <param name="departmentName">The department name for the department.</param>
        /// <param name="name">The name for the department.</param>

        public Department(DepartmentName departmentName, string name = null)
        {
            Id = (int)departmentName;

            // If we don't have a name argument, 
            // then use the string representation of the activity type for the name.
            Name = name ?? departmentName.ToString();
        }

        /// <summary>
        /// The ID of the department.
        /// This is the primary key. However, it is manually set right now rather than auto-incremented.
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }
    }
}