namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutherFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Auther", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Auther");
        }
    }
}
