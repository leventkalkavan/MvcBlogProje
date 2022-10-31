namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messagecs_update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "MSubject", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MSubject", c => c.String(maxLength: 100));
        }
    }
}
