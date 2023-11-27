using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Customrelationpayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_quotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_quotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    QuotaId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_payments_t_activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "t_activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_t_payments_t_quotas_QuotaId",
                        column: x => x.QuotaId,
                        principalTable: "t_quotas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_payments_ActivityId",
                table: "t_payments",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_t_payments_QuotaId",
                table: "t_payments",
                column: "QuotaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_payments");

            migrationBuilder.DropTable(
                name: "t_quotas");
        }
    }
}
