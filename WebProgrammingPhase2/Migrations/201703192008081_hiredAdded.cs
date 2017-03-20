namespace WebProgrammingPhase2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hiredAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "Rating", c => c.String());
            AddColumn("dbo.Applicants", "isTop5", c => c.String());
            AddColumn("dbo.Applicants", "isHired", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "isHired");
            DropColumn("dbo.Applicants", "isTop5");
            DropColumn("dbo.Applicants", "Rating");
        }
    }
}
