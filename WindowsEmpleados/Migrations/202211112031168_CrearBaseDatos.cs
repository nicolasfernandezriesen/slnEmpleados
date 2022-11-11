namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Cuit = c.String(),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        IdDepartamento = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdDepartamento);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        IdEmpleado = c.Int(nullable: false, identity: true),
                        Legajo = c.String(),
                        Departamento_IdDepartamento = c.Int(),
                    })
                .PrimaryKey(t => t.IdEmpleado)
                .ForeignKey("dbo.Departamento", t => t.Departamento_IdDepartamento)
                .Index(t => t.Departamento_IdDepartamento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleado", "Departamento_IdDepartamento", "dbo.Departamento");
            DropIndex("dbo.Empleado", new[] { "Departamento_IdDepartamento" });
            DropTable("dbo.Empleado");
            DropTable("dbo.Departamento");
            DropTable("dbo.Cliente");
        }
    }
}
