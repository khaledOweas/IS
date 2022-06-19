namespace ISData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Innovations", "CreatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Innovations", "CreatedBy");
        }
    }
}
