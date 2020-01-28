namespace reviewStudyASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        titulo = c.String(nullable: false, maxLength: 130),
                        estaEnCartelera = c.Boolean(nullable: false),
                        genero = c.String(maxLength: 120),
                        sinopsis = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Peliculas");
        }
    }
}
