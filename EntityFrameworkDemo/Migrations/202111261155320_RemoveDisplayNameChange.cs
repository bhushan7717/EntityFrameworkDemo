namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDisplayNameChange : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "display_name", newName: "UserName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Users", name: "UserName", newName: "display_name");
        }
    }
}
