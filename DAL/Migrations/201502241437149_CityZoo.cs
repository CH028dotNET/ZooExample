namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityZoo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZooCity",
                c => new
                    {
                        ZooId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ZooId, t.CityId })
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Zoo", t => t.ZooId, cascadeDelete: true)
                .Index(t => t.ZooId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZooCity", "ZooId", "dbo.Zoo");
            DropForeignKey("dbo.ZooCity", "CityId", "dbo.City");
            DropForeignKey("dbo.Zoo", "City_Id", "dbo.City");
            DropIndex("dbo.ZooCity", new[] { "CityId" });
            DropIndex("dbo.ZooCity", new[] { "ZooId" });
            DropColumn("dbo.Zoo", "City_Id");
            DropTable("dbo.ZooCity");
            DropTable("dbo.City");
        }
    }
}
