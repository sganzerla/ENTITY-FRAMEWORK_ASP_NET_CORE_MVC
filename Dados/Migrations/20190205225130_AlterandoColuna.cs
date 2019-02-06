﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Dados.Migrations
{
    public partial class AlterandoColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produto2");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produto2",
                newName: "IX_Produto2_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto2",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto2",
                table: "Produto2",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto2_Categorias_CategoriaId",
                table: "Produto2",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto2_Categorias_CategoriaId",
                table: "Produto2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto2",
                table: "Produto2");

            migrationBuilder.RenameTable(
                name: "Produto2",
                newName: "Produtos");

            migrationBuilder.RenameIndex(
                name: "IX_Produto2_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}