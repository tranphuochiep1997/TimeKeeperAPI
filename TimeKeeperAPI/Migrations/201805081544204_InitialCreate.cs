namespace TimeKeeperAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        UserID = c.Guid(nullable: false),
                        FileName = c.String(),
                        Location = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FullName = c.String(maxLength: 200),
                        Phone = c.String(maxLength: 12),
                        Email = c.String(maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.Phone, t.Email }, unique: true, name: "IX_EmailAndPhone");
            
            CreateTable(
                "dbo.Work",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        WorkName = c.String(maxLength: 50),
                        Color = c.Int(nullable: false),
                        UserID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.TimeItem",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        StartAt = c.DateTimeOffset(nullable: false, precision: 7),
                        EndAt = c.DateTimeOffset(nullable: false, precision: 7),
                        Description = c.String(),
                        WorkID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Work", t => t.WorkID, cascadeDelete: true)
                .Index(t => t.WorkID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Work", "UserID", "dbo.User");
            DropForeignKey("dbo.TimeItem", "WorkID", "dbo.Work");
            DropForeignKey("dbo.Memory", "UserID", "dbo.User");
            DropIndex("dbo.TimeItem", new[] { "WorkID" });
            DropIndex("dbo.Work", new[] { "UserID" });
            DropIndex("dbo.User", "IX_EmailAndPhone");
            DropIndex("dbo.Memory", new[] { "UserID" });
            DropTable("dbo.TimeItem");
            DropTable("dbo.Work");
            DropTable("dbo.User");
            DropTable("dbo.Memory");
        }
    }
}
