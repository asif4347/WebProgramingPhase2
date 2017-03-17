namespace WebProgrammingPhase2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Education = c.String(nullable: false),
                        Department = c.String(nullable: false),
                        jobTiltile = c.String(nullable: false),
                        Skills = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applicants");
        }
    }
}
