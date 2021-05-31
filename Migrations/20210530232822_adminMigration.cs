using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Huerto_Del_valle.Migrations
{
    public partial class adminMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
           

            migrationBuilder.CreateTable(
                name: "t_producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    url_producto = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    precio = table.Column<double>(type: "double precision", nullable: false),
                    lugarcompraproducto = table.Column<string>(type: "text", nullable: false),
                    usuario = table.Column<string>(type: "text", nullable: false),
                    addDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    tipo_producto = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_producto", x => x.Id);
                });

           

            
        }

       
    }
}
