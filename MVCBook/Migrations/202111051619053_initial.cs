namespace MVCBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Author = c.String(maxLength: 50, unicode: false),
                        PagesNumber = c.Int(nullable: false),
                        Publisher = c.String(maxLength: 8000, unicode: false),
                        PublicationDate = c.String(maxLength: 8000, unicode: false),
                        Content = c.String(maxLength: 8000, unicode: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        PriceConfirm = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Book");
        }
    }
}
