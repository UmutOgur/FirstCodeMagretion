namespace CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonelsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        PersonelAd = c.String(),
                        PersonelSOYAD = c.String(),
                    })
                .PrimaryKey(t => t.PersonelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personels");
        }
    }
}
