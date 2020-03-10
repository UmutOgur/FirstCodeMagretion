namespace CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMüsterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Müsteri",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriADİ = c.String(),
                        MusteriSOYADİ = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
            AlterColumn("dbo.Ürünler", "UrunKategori", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ürünler", "UrunKategori", c => c.String());
            DropTable("dbo.Müsteri");
        }
    }
}
