namespace CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKategoriDetayColumnKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoris", "KategoriDetay");
        }
    }
}
