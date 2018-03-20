using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CorgiDev.StaffDirectoryProject.Models
{
    public class Skill
    {
        public enum SkillType
        {
            AccessiblePDF = 1,
            AccessiblePowerPoint = 2,
            AccessibleWordDocument = 3,
            AccessibleExcelDocument = 4,
            BrailleTranslation = 5,
            EmbosserUse = 6,
            AccessibleImages = 7,
            AccessibleWebDesign = 8,
            AccessibleProductDesign = 9,
            AccessibleTestDesign = 10
        }

        /// <summary>
        /// Constructors a skill for the provided skill type and name.
        /// </summary>
        /// <param name="skillType">The skill type for the skill.</param>
        /// <param name="name">The name for the skill.</param>

        public Skill(SkillType skillType, string name = null)
        {
            Id = (int)skillType;

            // If we don't have a name argument, 
            // then use the string representation of the skill type for the name.
            Name = name ?? Enum.GetName(typeof(SkillType), skillType);
        }

        public Skill()
        {
            
        }

        /// <summary>
        /// The ID of the skill.
        /// </summary>
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}