namespace CoomingSoonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminsId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}