namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassportTableAdded1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passports",
                c => new
                    {
                        PassportNumber = c.Int(nullable: false),
                        IssuingCountry = c.String(nullable: false, maxLength: 128),
                        IssuedDate = c.DateTime(nullable: false),
                        Expires = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.PassportNumber, t.IssuingCountry });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Passports");
        }
    }
}
