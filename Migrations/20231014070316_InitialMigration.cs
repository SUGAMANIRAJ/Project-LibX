using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLibX.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_of_the_Student = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEM = table.Column<int>(type: "int", nullable: false),
                    ContInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Book2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Book3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Book4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Book5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
