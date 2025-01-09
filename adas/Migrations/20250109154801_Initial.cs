using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuit = table.Column<long>(type: "bigint", nullable: false),
                    Dni = table.Column<long>(type: "bigint", nullable: false),
                    Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Cuit", "Dni", "Email", "LastName", "Nacimiento", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 20304050601L, 20304050L, "maradona10@argentina.com", "Maradona", new DateTime(1960, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego", 1140000001 },
                    { 2, 20708090101L, 40708090L, "messi10@argentina.com", "Messi", new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", 1140000002 },
                    { 3, 20333333401L, 30333333L, "sabatini@argentina.com", "Sabatini", new DateTime(1970, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela", 1140000003 },
                    { 4, 20123456701L, 10123456L, "papa_francisco@vaticano.com", "Bergoglio", new DateTime(1936, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jorge", 1140000004 },
                    { 5, 20567890101L, 50678901L, "ginobili20@argentina.com", "Ginóbili", new DateTime(1977, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel", 1140000005 },
                    { 6, 20122334455L, 20122334L, "pergolini@cqc.com", "Pergolini", new DateTime(1964, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mario", 1140000006 },
                    { 7, 20111223344L, 20111223L, "francella@actor.com", "Francella", new DateTime(1955, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo", 1140000007 },
                    { 8, 20444444401L, 40444444L, "darin@actor.com", "Darín", new DateTime(1957, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo", 1140000010 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
