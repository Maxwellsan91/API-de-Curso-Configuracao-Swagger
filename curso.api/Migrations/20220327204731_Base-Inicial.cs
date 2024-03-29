﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace curso.api.Migrations
{
    public partial class BaseInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Usuario",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Usuario", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Curso",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    CodUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Curso", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Tb_Curso_Tb_Usuario_CodUsuario",
                        column: x => x.CodUsuario,
                        principalTable: "Tb_Usuario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Curso_CodUsuario",
                table: "Tb_Curso",
                column: "CodUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Curso");

            migrationBuilder.DropTable(
                name: "Tb_Usuario");
        }
    }
}
