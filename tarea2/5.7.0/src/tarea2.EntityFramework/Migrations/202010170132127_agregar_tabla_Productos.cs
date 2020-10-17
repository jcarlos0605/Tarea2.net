namespace tarea2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregar_tabla_Productos : DbMigration
    {
        public override void Up()
        {
             CreateTable(
                "dbo.Productos",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Codigo = c.String(),
                    Descripcion = c.String(),
                    Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Existencia = c.Int(nullable: false),
                    Activo = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
        }
    }
}
