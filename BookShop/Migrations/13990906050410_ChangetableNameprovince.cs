using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class ChangetableNameprovince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provices_ProviceProvinceID",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provices",
                table: "Provices");

            migrationBuilder.RenameTable(
                name: "Provices",
                newName: "Province");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "BookInfo",
                nullable: true,
                defaultValueSql: "convert(datetime,GETDATE())",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Province",
                table: "Province",
                column: "ProvinceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Province_ProviceProvinceID",
                table: "Cities",
                column: "ProviceProvinceID",
                principalTable: "Province",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Province_ProviceProvinceID",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Province",
                table: "Province");

            migrationBuilder.RenameTable(
                name: "Province",
                newName: "Provices");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "BookInfo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "convert(datetime,GETDATE())");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provices",
                table: "Provices",
                column: "ProvinceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provices_ProviceProvinceID",
                table: "Cities",
                column: "ProviceProvinceID",
                principalTable: "Provices",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
