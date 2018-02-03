namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Author = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        ReleaseDate = c.DateTime(),
                        ISBN = c.String(nullable: false),
                        BookGenreID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.DictBookGenres", t => t.BookGenreID, cascadeDelete: true)
                .Index(t => t.BookGenreID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookGenreID", "dbo.DictBookGenres");
            DropIndex("dbo.Books", new[] { "BookGenreID" });
            DropTable("dbo.Books");
        }
    }
}
