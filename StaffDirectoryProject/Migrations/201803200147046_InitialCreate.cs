namespace StaffDirectoryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeClockNumber = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        JobTitle = c.String(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        EmailAddress = c.String(),
                        SkillId = c.Int(nullable: false),
                        Notes = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.SkillId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.Entries", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Entries", new[] { "SkillId" });
            DropIndex("dbo.Entries", new[] { "DepartmentId" });
            DropTable("dbo.Skills");
            DropTable("dbo.Entries");
            DropTable("dbo.Departments");
        }
    }
}
