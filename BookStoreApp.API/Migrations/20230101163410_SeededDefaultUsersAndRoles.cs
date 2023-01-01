using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e543f8c-0093-4aa1-ad0b-18368c9b099d", "cb1a728f-3221-4ce2-a295-905653bca3c1", "User", "USER" },
                    { "95c93ace-7651-44c4-8737-52851d614f32", "6a38a967-4c7b-4263-b428-4431389d9f2e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "610268a8-2b23-494e-856c-6bba84e7ebcc", 0, "efd6d984-fe04-4f07-9ebb-a2cf1eeaaeab", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEJI0zI+kY9yWSQ7QT6Hr4CTxybCEccKudJkxJhM5nirKEE4xwAV2eInX7jYSGqlWrw==", null, false, "160b5c0d-f8aa-449f-becf-8007bd1a11de", false, "admin@bookstore.com" },
                    { "cf833103-d733-4402-b00c-1263ca230e72", 0, "8eeabc32-7175-4672-9e39-a541009a4e43", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELyHQP6i2RxBM53AyxX81Kiw+M7ID18A7stcJSPqHNlVHax/Ab6CTEiJigNPM5SAQQ==", null, false, "5d86484f-fd06-47c7-98f3-ce3d7522c69c", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "95c93ace-7651-44c4-8737-52851d614f32", "610268a8-2b23-494e-856c-6bba84e7ebcc" },
                    { "0e543f8c-0093-4aa1-ad0b-18368c9b099d", "cf833103-d733-4402-b00c-1263ca230e72" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95c93ace-7651-44c4-8737-52851d614f32", "610268a8-2b23-494e-856c-6bba84e7ebcc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e543f8c-0093-4aa1-ad0b-18368c9b099d", "cf833103-d733-4402-b00c-1263ca230e72" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e543f8c-0093-4aa1-ad0b-18368c9b099d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95c93ace-7651-44c4-8737-52851d614f32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610268a8-2b23-494e-856c-6bba84e7ebcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf833103-d733-4402-b00c-1263ca230e72");
        }
    }
}
