using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDemo.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Ideas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ideas",
                keyColumn: "IdeasId",
                keyValue: 1,
                column: "Title",
                value: "Title 1");

            migrationBuilder.UpdateData(
                table: "Ideas",
                keyColumn: "IdeasId",
                keyValue: 2,
                column: "Title",
                value: "Title 2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Ideas");
        }
    }
}
