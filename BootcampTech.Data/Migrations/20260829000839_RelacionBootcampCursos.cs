using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootcampTech.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelacionBootcampCursos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BootcampId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "bootcamps",
                columns: table => new
                {
                    BootcampId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bootcamps", x => x.BootcampId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_BootcampId",
                table: "Courses",
                column: "BootcampId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_bootcamps_BootcampId",
                table: "Courses",
                column: "BootcampId",
                principalTable: "bootcamps",
                principalColumn: "BootcampId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_bootcamps_BootcampId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "bootcamps");

            migrationBuilder.DropIndex(
                name: "IX_Courses_BootcampId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "BootcampId",
                table: "Courses");
        }
    }
}
