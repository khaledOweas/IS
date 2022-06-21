namespace ISData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ISDB3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            AddColumn("dbo.Innovations", "InnovationCategory_Name", c => c.String(maxLength: 128));
            CreateIndex("dbo.Innovations", "InnovationCategory_Name");
            AddForeignKey("dbo.Innovations", "InnovationCategory_Name", "dbo.Categories", "Name");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Innovations", "InnovationCategory_Name", "dbo.Categories");
            DropIndex("dbo.Innovations", new[] { "InnovationCategory_Name" });
            DropColumn("dbo.Innovations", "InnovationCategory_Name");
            DropTable("dbo.Categories");
        }
    }
}
