namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Animalstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ZooId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Zoo", t => t.ZooId, cascadeDelete: true)
                .Index(t => t.ZooId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animal", "ZooId", "dbo.Zoo");
            DropIndex("dbo.Animal", new[] { "ZooId" });
            DropTable("dbo.Animal");
        }
    }
}
