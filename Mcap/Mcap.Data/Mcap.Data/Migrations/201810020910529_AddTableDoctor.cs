namespace Mcap.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableDoctor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        User = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}
