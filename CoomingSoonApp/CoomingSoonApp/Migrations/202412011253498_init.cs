namespace CoomingSoonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailReqs",
                c => new
                    {
                        EmailReqId = c.Int(nullable: false, identity: true),
                        ReqDate = c.DateTime(nullable: false),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.EmailReqId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        RequestDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Message = c.String(),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Requests");
            DropTable("dbo.EmailReqs");
        }
    }
}
