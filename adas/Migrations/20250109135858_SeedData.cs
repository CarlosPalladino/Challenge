using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Cuit", "Dni", "Email", "LastName", "Nacimiento", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 20304050601L, 20304050, "maradona10@argentina.com", "Maradona", new DateTime(1960, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego", 1140000001 },
                    { 2, 20708090101L, 40708090, "messi10@argentina.com", "Messi", new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", 1140000002 },
                    { 3, 20333333401L, 30333333, "sabatini@argentina.com", "Sabatini", new DateTime(1970, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela", 1140000003 },
                    { 4, 20123456701L, 10123456, "papa_francisco@vaticano.com", "Bergoglio", new DateTime(1936, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jorge", 1140000004 },
                    { 5, 20567890101L, 50678901, "ginobili20@argentina.com", "Ginóbili", new DateTime(1977, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel", 1140000005 },
                    { 6, 20122334455L, 20122334, "pergolini@cqc.com", "Pergolini", new DateTime(1964, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mario", 1140000006 },
                    { 7, 20111223344L, 20111223, "francella@actor.com", "Francella", new DateTime(1955, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo", 1140000007 },
                    { 8, 20444444401L, 40444444, "darin@actor.com", "Darín", new DateTime(1957, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo", 1140000010 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Cuit", "Dni", "Email", "LastName", "Nacimiento", "Name", "Phone" },
                values: new object[,]
                {
                    { -8, 20444444401L, 40444444, "darin@actor.com", "Darín", new DateTime(1957, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricardo", 1140000010 },
                    { -7, 20111223344L, 20111223, "francella@actor.com", "Francella", new DateTime(1955, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo", 1140000007 },
                    { -6, 20122334455L, 20122334, "pergolini@cqc.com", "Pergolini", new DateTime(1964, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mario", 1140000006 },
                    { -5, 20567890101L, 50678901, "ginobili20@argentina.com", "Ginóbili", new DateTime(1977, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel", 1140000005 },
                    { -4, 20123456701L, 10123456, "papa_francisco@vaticano.com", "Bergoglio", new DateTime(1936, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jorge", 1140000004 },
                    { -3, 20333333401L, 30333333, "sabatini@argentina.com", "Sabatini", new DateTime(1970, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela", 1140000003 },
                    { -2, 20708090101L, 40708090, "messi10@argentina.com", "Messi", new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lionel", 1140000002 },
                    { -1, 20304050601L, 20304050, "maradona10@argentina.com", "Maradona", new DateTime(1960, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego", 1140000001 }
                });
        }
    }
}
