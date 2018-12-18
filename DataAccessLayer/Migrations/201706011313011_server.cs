namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class server : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerMessage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Status = c.String(),
                        Description = c.String(nullable: false, maxLength: 200),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 25),
                        UserName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PlanningStartDate = c.DateTime(nullable: false),
                        PlanningEndDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BeginDate = c.DateTime(nullable: false),
                        FinalDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50),
                        EmloyeeId = c.Int(nullable: false),
                        Project_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmloyeeId, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.Project_ID)
                .Index(t => t.EmloyeeId)
                .Index(t => t.Project_ID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SocialNumber = c.String(nullable: false, maxLength: 20, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 60, unicode: false),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(nullable: false, maxLength: 50, unicode: false),
                        Country = c.String(nullable: false, maxLength: 50, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Status = c.String(nullable: false, maxLength: 50, unicode: false),
                        TitleId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 15),
                        UserName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Gender", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Title", t => t.TitleId, cascadeDelete: true)
                .Index(t => t.TitleId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.Gender",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GenderType = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Title",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TitleName = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Task", "Project_ID", "dbo.Project");
            DropForeignKey("dbo.Employee", "TitleId", "dbo.Title");
            DropForeignKey("dbo.Task", "EmloyeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "GenderId", "dbo.Gender");
            DropForeignKey("dbo.CustomerMessage", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Employee", new[] { "GenderId" });
            DropIndex("dbo.Employee", new[] { "TitleId" });
            DropIndex("dbo.Task", new[] { "Project_ID" });
            DropIndex("dbo.Task", new[] { "EmloyeeId" });
            DropIndex("dbo.Project", new[] { "CustomerID" });
            DropIndex("dbo.CustomerMessage", new[] { "CustomerID" });
            DropTable("dbo.Title");
            DropTable("dbo.Gender");
            DropTable("dbo.Employee");
            DropTable("dbo.Task");
            DropTable("dbo.Project");
            DropTable("dbo.Customer");
            DropTable("dbo.CustomerMessage");
        }
    }
}
