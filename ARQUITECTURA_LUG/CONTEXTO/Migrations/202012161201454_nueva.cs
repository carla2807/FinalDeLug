namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nueva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.COMPARTIRs",
                c => new
                    {
                        CODIGO = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        FECHA = c.DateTime(nullable: false),
                        MATERIAL_CODIGO = c.Int(),
                    })
                .PrimaryKey(t => t.CODIGO)
                .ForeignKey("dbo.MATERIALs", t => t.MATERIAL_CODIGO)
                .Index(t => t.MATERIAL_CODIGO);
            
            CreateTable(
                "dbo.MATERIALs",
                c => new
                    {
                        CODIGO = c.Int(nullable: false, identity: true),
                        TITULO = c.String(),
                        NOMBRE_AUTOR = c.String(),
                        AÑO_EDICION = c.Int(nullable: false),
                        TIPO_MATERIAL = c.String(),
                        NOMBRE_ARCHIVO = c.String(),
                        TAMAÑO_MEGABYTE = c.Int(),
                        CANTIDAD_HOJAS = c.Int(),
                        ENCUADERNADO = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        TEMA_CODIGO = c.Int(),
                    })
                .PrimaryKey(t => t.CODIGO)
                .ForeignKey("dbo.TEMAs", t => t.TEMA_CODIGO)
                .Index(t => t.TEMA_CODIGO);
            
            CreateTable(
                "dbo.TEMAs",
                c => new
                    {
                        CODIGO = c.Int(nullable: false, identity: true),
                        TEMA_LIBRO = c.String(),
                    })
                .PrimaryKey(t => t.CODIGO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.COMPARTIRs", "MATERIAL_CODIGO", "dbo.MATERIALs");
            DropForeignKey("dbo.MATERIALs", "TEMA_CODIGO", "dbo.TEMAs");
            DropIndex("dbo.MATERIALs", new[] { "TEMA_CODIGO" });
            DropIndex("dbo.COMPARTIRs", new[] { "MATERIAL_CODIGO" });
            DropTable("dbo.TEMAs");
            DropTable("dbo.MATERIALs");
            DropTable("dbo.COMPARTIRs");
        }
    }
}
