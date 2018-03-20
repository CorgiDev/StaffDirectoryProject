using System.Collections.Generic;

namespace CorgiDev.StaffDirectoryProject.Migrations
{
    using CorgiDev.StaffDirectoryProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StaffDirectoryProject.Data.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StaffDirectoryProject.Data.MyDbContext context)
        {
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
                new Entry(1, 691, "John", "Smith", "Lead Graphic Designer", Department.DepartmentName.GraphicProduction, "123-123-1234", "jsmith@domain.com", Skill.SkillType.AccessibleImages),
                new Entry(2, 912, "Jane", "Smith", "Lead Production Engineer", Department.DepartmentName.Engineering, "234-234-2345", "jasmith@domain.com", Skill.SkillType.AccessibleProductDesign),
                new Entry(3, 132, "Scott", "Jones", "Lead Test Designer", Department.DepartmentName.ATT, "345-345-3456", "sjones@domain.com", Skill.SkillType.AccessibleTestDesign),
                new Entry(4, 123, "Mary", "Smith", "Lead Researcher", Department.DepartmentName.EducationalProductResearch, "456-456-4567", "msmith@domain.com", Skill.SkillType.AccessiblePDF),
                new Entry(5, 556, "Elizabeth", "Gray", "Computer Support Specialist", Department.DepartmentName.CTS, "567-567-5678", "egray@domain.com", Skill.SkillType.AccessiblePowerPoint),
                new Entry(6, 621, "Jacob", "Scott", "Lead Accountant", Department.DepartmentName.MarketingAndSales, "678-678-6789", "jscott@domain.com", Skill.SkillType.AccessibleExcelDocument),
                new Entry(7, 543, "Jason", "Willis", "VP of Educational Services and Product Development", Department.DepartmentName.Executive, "789-789-7890", "jwillis@domain.com", Skill.SkillType.AccessibleWordDocument),
                new Entry(8, 882, "Ben", "Appleton", "Lead Web Developer", Department.DepartmentName.TPR, "890-890-8901", "bappleton@domain.com", Skill.SkillType.AccessibleWebDesign),
                new Entry(9, 953, "Lindsey", "Brymer", "Lead Transcriber", Department.DepartmentName.BrailleTranscription, "901-901-9012", "LBrymer@domain.com", Skill.SkillType.BrailleTranslation),
                new Entry(10, 105, "Janette", "Williams", "Lead Braillo Operator", Department.DepartmentName.BrailleProduction, "102-102-1023", "jwilliams@domain.com", Skill.SkillType.EmbosserUse)
            };
            context.Departments.AddRange(departments);
            context.Skills.AddRange(skills);
            context.Entries.AddRange(entries);
            context.SaveChanges();
        }
    }
}
