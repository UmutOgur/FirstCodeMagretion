namespace CodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteKategoriDetayiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.Kategoris", "KategoriDetayi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriDetayi", c => c.String());
            
        }
    }
}
