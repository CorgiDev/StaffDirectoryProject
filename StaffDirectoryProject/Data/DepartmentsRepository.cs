using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CorgiDev.StaffDirectoryProject.Models;

namespace CorgiDev.StaffDirectoryProject.Data
{
    /// <summary>
    /// Repository for activities.
    /// 
    /// Note: The code in this class is not to be considered a "best practice" 
    /// example of how to do data persistence, but rather as workaround for
    /// not having a database to persist data to. I will switch to a database at a later time.
    /// </summary>
    public class DepartmentsRepository
    {
        /// <summary>
        /// Returns a collection of activities.
        /// </summary>
        /// <returns>A list of activities.</returns>
        public List<Department> GetDepartments()
        {
            return Data.Departments
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}