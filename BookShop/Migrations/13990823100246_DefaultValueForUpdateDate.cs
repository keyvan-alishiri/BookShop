using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class DefaultValueForUpdateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "BookInfo",
                nullable: true,
                defaultValueSql: "convert(datetime,GETDATE())",
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "BookInfo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "convert(datetime,GETDATE())");
        }
    }
}
