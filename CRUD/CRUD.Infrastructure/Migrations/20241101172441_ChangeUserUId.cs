using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.Infrastructure.Migrations
{
    public partial class ChangeUserUId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "Users",
                newName: "UId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UId",
                table: "Users",
                newName: "Uid");
        }
    }
}
