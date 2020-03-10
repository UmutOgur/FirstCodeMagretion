namespace CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategoriDetayiToKategoriDetayInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriDetayi", a => a.String());
            Sql("update Kategoris set KategoriDetayi=KategoriDetay");
            DropColumn("dbo.Kategoris", "KategoriDetay");
        }
        
        public override void Down()
        {

            AddColumn("dbo.Kategoris", "KategoriDetay", a => a.String());
            Sql("update Kategoris set KategoriDetay=KategoriDetayi");
            DropColumn("dbo.Kategoris", "KategoriDetayi");
        }
    }
}
