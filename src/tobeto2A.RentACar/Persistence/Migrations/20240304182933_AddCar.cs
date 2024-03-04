using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e3472b7e-08ad-463e-b2c3-959fe6755bee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45e2f46b-84e8-4dc1-884f-3f0bc68dc673"));

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameIndex(
                name: "IX_Car_ModelId",
                table: "Cars",
                newName: "IX_Cars_ModelId");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cars.Admin", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cars.Read", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cars.Write", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cars.Create", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cars.Update", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cars.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("0126bf33-6f89-4e45-91a6-c93519f9a355"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 63, 27, 97, 82, 101, 192, 217, 195, 202, 46, 180, 164, 7, 126, 110, 121, 129, 252, 9, 235, 30, 62, 54, 233, 158, 237, 81, 112, 168, 65, 46, 140, 240, 153, 6, 80, 144, 162, 44, 14, 192, 247, 138, 224, 112, 152, 50, 3, 67, 55, 184, 178, 51, 122, 140, 91, 115, 17, 210, 62, 240, 11, 27, 185 }, new byte[] { 193, 152, 116, 123, 214, 144, 233, 74, 108, 56, 236, 221, 217, 222, 194, 125, 199, 84, 111, 102, 197, 224, 121, 242, 188, 177, 205, 60, 249, 68, 9, 236, 97, 200, 89, 111, 57, 20, 87, 221, 177, 120, 77, 218, 249, 110, 58, 32, 245, 114, 108, 33, 120, 233, 26, 86, 124, 224, 15, 144, 168, 139, 85, 255, 160, 218, 39, 105, 77, 226, 209, 59, 45, 21, 109, 53, 113, 196, 6, 207, 141, 172, 9, 139, 25, 49, 35, 117, 25, 41, 32, 92, 60, 13, 25, 108, 209, 237, 149, 64, 180, 81, 12, 68, 86, 182, 78, 244, 226, 164, 165, 223, 33, 194, 210, 4, 120, 59, 23, 243, 0, 224, 79, 1, 174, 158, 248, 246 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("48c20980-5e30-434b-b80f-484b859c53da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("0126bf33-6f89-4e45-91a6-c93519f9a355") });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Model_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Model_ModelId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("48c20980-5e30-434b-b80f-484b859c53da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0126bf33-6f89-4e45-91a6-c93519f9a355"));

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ModelId",
                table: "Car",
                newName: "IX_Car_ModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("45e2f46b-84e8-4dc1-884f-3f0bc68dc673"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 78, 154, 208, 157, 74, 136, 195, 163, 125, 145, 43, 139, 17, 174, 118, 220, 172, 34, 118, 155, 144, 205, 146, 219, 176, 157, 213, 75, 51, 94, 233, 146, 117, 7, 212, 27, 55, 168, 2, 41, 123, 111, 87, 122, 38, 42, 143, 135, 54, 126, 209, 132, 101, 122, 123, 78, 75, 31, 3, 129, 51, 167, 213, 167 }, new byte[] { 124, 112, 5, 198, 124, 23, 50, 246, 147, 209, 1, 198, 58, 33, 85, 148, 113, 66, 102, 210, 185, 168, 96, 113, 10, 167, 63, 177, 234, 137, 105, 212, 12, 136, 103, 131, 1, 59, 164, 203, 54, 50, 178, 94, 9, 197, 59, 8, 76, 182, 12, 11, 75, 132, 179, 233, 16, 147, 136, 119, 130, 143, 217, 167, 145, 145, 242, 135, 227, 229, 141, 19, 201, 54, 140, 188, 33, 107, 231, 12, 176, 169, 126, 58, 100, 173, 247, 153, 207, 255, 223, 162, 236, 96, 159, 153, 204, 98, 5, 128, 247, 221, 6, 59, 150, 237, 177, 59, 158, 232, 56, 252, 240, 43, 80, 173, 36, 179, 22, 164, 17, 165, 226, 36, 241, 181, 112, 57 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e3472b7e-08ad-463e-b2c3-959fe6755bee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("45e2f46b-84e8-4dc1-884f-3f0bc68dc673") });

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id");
        }
    }
}
