using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NewTableSpecialActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_special_activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SpecialProperty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_special_activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_special_activities_t_activities_Id",
                        column: x => x.Id,
                        principalTable: "t_activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_special_activities");
        }
    }
}
