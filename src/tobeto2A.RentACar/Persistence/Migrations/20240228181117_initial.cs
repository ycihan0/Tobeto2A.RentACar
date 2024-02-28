using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brands_BrandId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Fuel_FuelId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Transmisson_TransmissionId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_BrandId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_FuelId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_TransmissionId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Car_ModelId",
                table: "Car");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("27570b9d-977b-410a-aeda-2db6af6dc677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f3c285a-125d-4aeb-93da-cde0e26ac037"));

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "DailyPrice",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "TransmissionId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Car");

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Transmisson",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Model",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Model",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Fuel",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("75de624d-e7f5-447a-8735-d35832f470ba"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 210, 62, 185, 2, 102, 236, 96, 157, 94, 85, 226, 187, 174, 252, 107, 43, 197, 10, 178, 195, 22, 169, 96, 123, 89, 116, 206, 200, 153, 171, 124, 10, 104, 249, 55, 89, 116, 109, 226, 158, 105, 81, 30, 160, 252, 232, 71, 227, 107, 208, 77, 177, 12, 37, 118, 37, 37, 252, 242, 61, 194, 81, 40, 120 }, new byte[] { 211, 236, 222, 124, 79, 62, 146, 86, 247, 193, 192, 235, 158, 185, 112, 34, 55, 43, 87, 29, 239, 134, 130, 112, 185, 77, 132, 210, 36, 251, 47, 208, 216, 122, 50, 108, 158, 107, 153, 161, 70, 15, 90, 199, 184, 74, 154, 235, 63, 94, 210, 92, 42, 211, 41, 96, 141, 19, 102, 255, 228, 37, 124, 209, 11, 247, 106, 125, 212, 181, 69, 214, 139, 1, 155, 18, 207, 80, 100, 138, 172, 236, 87, 150, 248, 45, 21, 68, 202, 121, 125, 172, 136, 46, 89, 46, 41, 207, 168, 196, 217, 203, 55, 49, 67, 139, 184, 29, 167, 79, 35, 167, 189, 104, 216, 109, 50, 102, 2, 236, 55, 160, 155, 151, 249, 9, 189, 185 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("48ab34b6-7694-444e-b913-5aafb19bb692"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("75de624d-e7f5-447a-8735-d35832f470ba") });

            migrationBuilder.CreateIndex(
                name: "IX_Transmisson_ModelId",
                table: "Transmisson",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuel_ModelId",
                table: "Fuel",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fuel_Model_ModelId",
                table: "Fuel",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transmisson_Model_ModelId",
                table: "Transmisson",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fuel_Model_ModelId",
                table: "Fuel");

            migrationBuilder.DropForeignKey(
                name: "FK_Transmisson_Model_ModelId",
                table: "Transmisson");

            migrationBuilder.DropIndex(
                name: "IX_Transmisson_ModelId",
                table: "Transmisson");

            migrationBuilder.DropIndex(
                name: "IX_Fuel_ModelId",
                table: "Fuel");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("48ab34b6-7694-444e-b913-5aafb19bb692"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75de624d-e7f5-447a-8735-d35832f470ba"));

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Transmisson");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Fuel");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Model",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "DailyPrice",
                table: "Model",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "FuelId",
                table: "Model",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransmissionId",
                table: "Model",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<short>(
                name: "Year",
                table: "Model",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Car",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2f3c285a-125d-4aeb-93da-cde0e26ac037"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 202, 251, 151, 150, 3, 132, 4, 114, 165, 113, 36, 132, 117, 137, 123, 16, 117, 62, 27, 162, 78, 250, 70, 152, 179, 183, 10, 116, 162, 132, 111, 219, 96, 190, 165, 130, 185, 82, 0, 187, 235, 144, 28, 236, 154, 174, 136, 76, 224, 101, 75, 235, 117, 153, 234, 16, 60, 76, 245, 43, 245, 50, 65, 199 }, new byte[] { 165, 89, 16, 237, 149, 124, 211, 166, 182, 153, 107, 98, 140, 10, 59, 209, 82, 221, 72, 209, 150, 185, 35, 228, 227, 138, 39, 22, 133, 46, 49, 206, 84, 189, 186, 76, 71, 2, 69, 71, 37, 90, 124, 112, 237, 121, 46, 57, 28, 18, 70, 201, 205, 184, 180, 36, 18, 28, 97, 162, 84, 240, 122, 212, 173, 13, 162, 2, 54, 26, 35, 251, 18, 105, 15, 252, 45, 191, 83, 9, 43, 69, 226, 178, 34, 165, 175, 128, 30, 217, 60, 148, 150, 68, 94, 2, 148, 233, 81, 164, 131, 243, 235, 162, 53, 1, 253, 188, 189, 153, 97, 128, 24, 71, 125, 243, 116, 149, 148, 106, 151, 125, 144, 96, 68, 42, 87, 147 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("27570b9d-977b-410a-aeda-2db6af6dc677"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2f3c285a-125d-4aeb-93da-cde0e26ac037") });

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandId",
                table: "Model",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_FuelId",
                table: "Model",
                column: "FuelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Model_TransmissionId",
                table: "Model",
                column: "TransmissionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_ModelId",
                table: "Car",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brands_BrandId",
                table: "Model",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Fuel_FuelId",
                table: "Model",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Transmisson_TransmissionId",
                table: "Model",
                column: "TransmissionId",
                principalTable: "Transmisson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
