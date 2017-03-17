namespace WebProgrammingPhase2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HRPersonnels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(nullable: false),
                        shortDes = c.String(nullable: false),
                        Department = c.String(nullable: false),
                        Position = c.String(nullable: false),
                        RequiredSkills = c.String(nullable: false),
                        ApplyTill = c.DateTime(nullable: false),
                        LongDes = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HRPersonnels");
        }
    }
}
