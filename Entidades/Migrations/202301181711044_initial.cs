namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 200, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Especialidad = c.String(nullable: false, maxLength: 20, unicode: false),
                        Matricula = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 200, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enfermero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cuil = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 200, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroHistoriaClinica = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 200, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Director",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PostGrado = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medico", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Director", "Id", "dbo.Medico");
            DropIndex("dbo.Director", new[] { "Id" });
            DropTable("dbo.Director");
            DropTable("dbo.Paciente");
            DropTable("dbo.Habitacion");
            DropTable("dbo.Enfermero");
            DropTable("dbo.Medico");
            DropTable("dbo.Clinica");
        }
    }
}
