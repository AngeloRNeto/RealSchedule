namespace RealSchedule.Entit_y.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Situacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Situacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Agenda_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agenda", t => t.Agenda_Id)
                .Index(t => t.Agenda_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Situacao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agenda", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Eventoes", "Agenda_Id", "dbo.Agenda");
            DropIndex("dbo.Eventoes", new[] { "Agenda_Id" });
            DropIndex("dbo.Agenda", new[] { "Usuario_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Eventoes");
            DropTable("dbo.Agenda");
        }
    }
}
