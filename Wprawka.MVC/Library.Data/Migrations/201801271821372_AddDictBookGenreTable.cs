namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDictBookGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DictBookGenres",
                c => new
                    {
                        BookGenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BookGenreID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DictBookGenres");
        }
    }
}
