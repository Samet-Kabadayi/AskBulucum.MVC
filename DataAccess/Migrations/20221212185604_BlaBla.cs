using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class BlaBla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Finders");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("71bd378a-854f-41a0-b565-2021bdaf1bfb"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3208), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8a5e1005-0744-45d9-8dad-e02f2110a27d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3206), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8ecbbdb3-50ad-4b66-9baa-1f27298695a7"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8efb1d22-30fc-4180-bf39-26ffb23a2428"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3204), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("01bbde4d-9a2e-4f90-b05d-0a8f95126caa"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8397), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d8f80b5-0053-4f9f-9567-d04932548e6e"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4716b89d-3237-4dcf-9901-0318a803ff81"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7679f24a-7d29-472c-b674-6431a9ab05f1"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8399), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cbe7752a-8eaf-4743-a487-4c6e62fb5658"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8404), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef7b23b3-39a0-448a-83ed-45eb6a1224da"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8394), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Finders",
                keyColumn: "Id",
                keyValue: new Guid("2394f0d0-07d9-43b5-9095-30c4975f449d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7345), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Finders",
                keyColumn: "Id",
                keyValue: new Guid("d22c2e26-fc10-4fdc-8a2e-ddcdbdbfba7f"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7356), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Proclamations",
                keyColumn: "Id",
                keyValue: new Guid("d4121c85-ee78-41fd-aa7f-dabc74d1536a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(9663), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2b097d52-677d-4915-8be0-1680b14a5010"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7667), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("316dfa77-073d-4672-bbf6-5d615575696c"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7676), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("664b6c0c-2cdf-46c3-bffe-164b9c6dae86"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7674), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab230d00-b037-4751-b727-dddc7cd9bb5d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7671), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c5d62390-65d4-44a3-a134-e1f2e63642dc"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7672), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Seekers",
                keyColumn: "Id",
                keyValue: new Guid("5b244afb-5101-430f-84f6-f48fafc339d8"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(5383), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Seekers",
                keyColumn: "Id",
                keyValue: new Guid("5eb98805-dc12-45ae-b97d-c97a81a0f0e6"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(5389), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("23cf33d2-4f95-4a36-973a-b0f6e69ce29d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7963), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("974dbdb9-2993-44ef-b57a-1240eb1fb597"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7968), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("d20902d0-022c-4918-8c53-53e267ec4885"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7966), new DateTime(2022, 12, 12, 21, 56, 3, 595, DateTimeKind.Local).AddTicks(7966) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Finders",
                type: "VARBINARY(500)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("71bd378a-854f-41a0-b565-2021bdaf1bfb"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8a5e1005-0744-45d9-8dad-e02f2110a27d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8598), new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8ecbbdb3-50ad-4b66-9baa-1f27298695a7"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8568), new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8efb1d22-30fc-4180-bf39-26ffb23a2428"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8595), new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("01bbde4d-9a2e-4f90-b05d-0a8f95126caa"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4044), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d8f80b5-0053-4f9f-9567-d04932548e6e"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4716b89d-3237-4dcf-9901-0318a803ff81"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7679f24a-7d29-472c-b674-6431a9ab05f1"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4047), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cbe7752a-8eaf-4743-a487-4c6e62fb5658"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef7b23b3-39a0-448a-83ed-45eb6a1224da"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Finders",
                keyColumn: "Id",
                keyValue: new Guid("2394f0d0-07d9-43b5-9095-30c4975f449d"),
                columns: new[] { "CreatedDate", "ModifiedDate", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2914), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2906), new byte[] { 51, 97, 53, 102, 99, 56, 49, 99, 97, 56, 102, 53, 57, 57, 55, 49, 51, 50, 101, 56, 101, 101, 99, 99, 100, 56, 54, 55, 50, 99, 99, 98 } });

            migrationBuilder.UpdateData(
                table: "Finders",
                keyColumn: "Id",
                keyValue: new Guid("d22c2e26-fc10-4fdc-8a2e-ddcdbdbfba7f"),
                columns: new[] { "CreatedDate", "ModifiedDate", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2925), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2922), new byte[] { 51, 97, 53, 102, 99, 56, 49, 99, 97, 56, 102, 53, 57, 57, 55, 49, 51, 50, 101, 56, 101, 101, 99, 99, 100, 56, 54, 55, 50, 99, 99, 98 } });

            migrationBuilder.UpdateData(
                table: "Proclamations",
                keyColumn: "Id",
                keyValue: new Guid("d4121c85-ee78-41fd-aa7f-dabc74d1536a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(5297), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2b097d52-677d-4915-8be0-1680b14a5010"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("316dfa77-073d-4672-bbf6-5d615575696c"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3305), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("664b6c0c-2cdf-46c3-bffe-164b9c6dae86"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab230d00-b037-4751-b727-dddc7cd9bb5d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c5d62390-65d4-44a3-a134-e1f2e63642dc"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3302), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Seekers",
                keyColumn: "Id",
                keyValue: new Guid("5b244afb-5101-430f-84f6-f48fafc339d8"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(949), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Seekers",
                keyColumn: "Id",
                keyValue: new Guid("5eb98805-dc12-45ae-b97d-c97a81a0f0e6"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(956), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("23cf33d2-4f95-4a36-973a-b0f6e69ce29d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3598), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("974dbdb9-2993-44ef-b57a-1240eb1fb597"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3603), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("d20902d0-022c-4918-8c53-53e267ec4885"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3601), new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3601) });
        }
    }
}
