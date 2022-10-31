namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messagecs_update2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "SenderMail", c => c.String());
            AlterColumn("dbo.Messages", "ReceiverMail", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "ReceiverMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Messages", "SenderMail", c => c.String(maxLength: 50));
        }
    }
}
