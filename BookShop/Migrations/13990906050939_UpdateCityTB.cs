using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class UpdateCityTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Province_ProviceProvinceID",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "ProviceProvinceID",
                table: "Cities",
                newName: "ProvinceID");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ProviceProvinceID",
                table: "Cities",
                newName: "IX_Cities_ProvinceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Province_ProvinceID",
                table: "Cities",
                column: "ProvinceID",
                principalTable: "Province",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Province_ProvinceID",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "ProvinceID",
                table: "Cities",
                newName: "ProviceProvinceID");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ProvinceID",
                table: "Cities",
                newName: "IX_Cities_ProviceProvinceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Province_ProviceProvinceID",
                table: "Cities",
                column: "ProviceProvinceID",
                principalTable: "Province",
                principalColumn: "ProvinceID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
