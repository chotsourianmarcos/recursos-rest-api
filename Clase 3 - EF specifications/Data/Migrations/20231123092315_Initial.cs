using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_users_t_persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "t_persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityItemUserItem",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityItemUserItem", x => new { x.ActivitiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ActivityItemUserItem_t_activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "t_activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivityItemUserItem_t_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "t_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityItemUserItem_UsersId",
                table: "ActivityItemUserItem",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_t_users_PersonId",
                table: "t_users",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityItemUserItem");

            migrationBuilder.DropTable(
                name: "t_activities");

            migrationBuilder.DropTable(
                name: "t_users");

            migrationBuilder.DropTable(
                name: "t_persons");
        }
    }
}
