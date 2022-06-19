namespace ISData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Innovations", "CreatedUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Innovations", "CreatedUserId");
            AddForeignKey("dbo.Innovations", "CreatedUserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Innovations", "CreatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Innovations", "CreatedBy", c => c.Int(nullable: false));
            DropForeignKey("dbo.Innovations", "CreatedUserId", "dbo.Users");
            DropIndex("dbo.Innovations", new[] { "CreatedUserId" });
            DropColumn("dbo.Innovations", "CreatedUserId");
            DropTable("dbo.Users");
        }
    }
}
