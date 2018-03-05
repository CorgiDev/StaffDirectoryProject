using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CorgiDev.StaffDirectoryProject.Models;

namespace CorgiDev.StaffDirectoryProject.Data
{
    public static class Data
    {
        /// <summary>
        /// The collection of departments.
        /// </summary>
        public static List<Department> Departments { get; set; }

        /// <summary>
        /// The collection of Skills.
        /// </summary>
        public static List<Skill> Skills { get; set; }

        /// <summary>
        /// The collection of entries.
        /// </summary>
        public static List<Entry> Entries { get; set; }

        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            // Create the collection of departments first
            // so we can reference them when creating the entries collection.
            var departments = new List<Department>()
            {
                new Department(Department.DepartmentName.Executive),
                new Department(Department.DepartmentName.CTS),
                new Department(Department.DepartmentName.TPR),
                new Department(Department.DepartmentName.BrailleProduction, "Braille Production"),
                new Department(Department.DepartmentName.ATT),
                new Department(Department.DepartmentName.GraphicProduction, "Graphic Production"),
                new Department(Department.DepartmentName.EducationalAides, "Educational Aides"),
                new Department(Department.DepartmentName.Engineering),
                new Department(Department.DepartmentName.BrailleProofreading, "Braille Proofreading"),
                new Department(Department.DepartmentName.BrailleTranscription, "Braille Transcription"),
                new Department(Department.DepartmentName.Planning),
                new Department(Department.DepartmentName.FieldServices, "Field Services"),
                new Department(Department.DepartmentName.ResourceServices, "Resource Services"),
                new Department(Department.DepartmentName.Shipping),
                new Department(Department.DepartmentName.EducationalProductResearch, "Educational Product Research"),
                new Department(Department.DepartmentName.MarketingAndSales, "Marketing and Sales")
            };

            var skills = new List<Skill>()
            {
                new Skill(Skill.SkillType.AccessiblePDF, "Accessible PDF"),
                new Skill(Skill.SkillType.AccessiblePowerPoint, "Accessible Power Point"),
                new Skill(Skill.SkillType.AccessibleWordDocument, "Accessible Word Document"),
                new Skill(Skill.SkillType.AccessibleExcelDocument, "Accessible Excel Document"),
                new Skill(Skill.SkillType.BrailleTranslation, "Braille Translation"),
                new Skill(Skill.SkillType.EmbosserUse, "Embosser Use"),
                new Skill(Skill.SkillType.AccessibleImages, "Accessible Images"),
                new Skill(Skill.SkillType.AccessibleWebDesign, "Accessible Web Design"),
                new Skill(Skill.SkillType.AccessibleProductDesign, "Accessible Product Design"),
                new Skill(Skill.SkillType.AccessibleTestDesign, "Accessible Test Design")
            };

            var entries = new List<Entry>()
            {
                new Entry(1, 691, "John", "Smith", "Lead Graphic Designer", Department.DepartmentName.GraphicProduction, Skill.SkillType.AccessibleImages),
                new Entry(2, 912, "Jane", "Smith", "Lead Production Engineer", Department.DepartmentName.Engineering, Skill.SkillType.AccessibleProductDesign),
                new Entry(3, 132, "Scott", "Jones", "Lead Test Designer", Department.DepartmentName.ATT, Skill.SkillType.AccessibleTestDesign),
                new Entry(4, 123, "Mary", "Smith", "Lead Researcher", Department.DepartmentName.EducationalProductResearch, Skill.SkillType.AccessiblePDF),
                new Entry(5, 556, "Elizabeth", "Gray", "Computer Support Specialist", Department.DepartmentName.CTS, Skill.SkillType.AccessiblePowerPoint),
                new Entry(6, 621, "Jacob", "Scott", "Lead Accountant", Department.DepartmentName.MarketingAndSales, Skill.SkillType.AccessibleExcelDocument),
                new Entry(7, 543, "Jason", "Willis", "VP of Educational Services and Product Development", Department.DepartmentName.Executive, Skill.SkillType.AccessibleWordDocument),
                new Entry(8, 882, "Ben", "Appleton", "Lead Web Developer", Department.DepartmentName.TPR, Skill.SkillType.AccessibleWebDesign),
                new Entry(9, 953, "Lindsey", "Brymer", "Lead Transcriber", Department.DepartmentName.BrailleTranscription, Skill.SkillType.BrailleTranslation),
                new Entry(10, 105, "Janette", "Williams", "Lead Braillo Operator", Department.DepartmentName.BrailleProduction, Skill.SkillType.EmbosserUse)
            };

            Departments = departments;
            Skills = skills;
            Entries = entries;
        }
    }
}