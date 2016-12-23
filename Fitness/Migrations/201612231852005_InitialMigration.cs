namespace Fitness.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Metcons",
                c => new
                    {
                        MetconId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Description = c.ToString()
                    })
                .PrimaryKey(t => t.MetconId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Metcons");
        }
    }
}
