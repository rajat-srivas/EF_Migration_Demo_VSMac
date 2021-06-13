using Microsoft.EntityFrameworkCore.Migrations;

namespace StackUpDemo.Migrations
{
    public partial class DbInitializationWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "EntityStatus" },
                values: new object[] { 1, "Active" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "EntityStatus" },
                values: new object[] { 2, "InActive" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "EntityStatus" },
                values: new object[] { 3, "Pending" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
