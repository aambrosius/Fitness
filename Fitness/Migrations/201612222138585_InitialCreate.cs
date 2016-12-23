namespace Fitness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athletes",
                c => new
                    {
                        AthleteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NickName = c.String(),
                    })
                .PrimaryKey(t => t.AthleteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Athletes");
        }
    }
}
