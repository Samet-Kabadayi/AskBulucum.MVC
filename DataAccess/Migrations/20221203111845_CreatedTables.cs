using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class CreatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seekers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    ConfirmEmail = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmPerson = table.Column<bool>(type: "bit", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seekers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seekers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Finders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmEmail = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmPerson = table.Column<bool>(type: "bit", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false),
                    SuccessfulWork = table.Column<int>(type: "int", nullable: false),
                    Vote = table.Column<decimal>(type: "Decimal(3,1)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finders_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Finders_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BrandVehicleType",
                columns: table => new
                {
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandVehicleType", x => new { x.BrandId, x.VehicleTypeId });
                    table.ForeignKey(
                        name: "FK_BrandVehicleType_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandVehicleType_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proclamations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Link = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProclamaionPrize = table.Column<decimal>(type: "money", nullable: false),
                    VehiclePrize = table.Column<decimal>(type: "money", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeekerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proclamations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proclamations_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proclamations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proclamations_Seekers_SeekerId",
                        column: x => x.SeekerId,
                        principalTable: "Seekers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "DeletedDate", "IsActive", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("71bd378a-854f-41a0-b565-2021bdaf1bfb"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8600), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8600), "Porsche" },
                    { new Guid("8a5e1005-0744-45d9-8dad-e02f2110a27d"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8598), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8598), "Audi" },
                    { new Guid("8ecbbdb3-50ad-4b66-9baa-1f27298695a7"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8568), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8576), "BMW" },
                    { new Guid("8efb1d22-30fc-4180-bf39-26ffb23a2428"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8595), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 204, DateTimeKind.Local).AddTicks(8596), "Mercedes" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "DeletedDate", "IsActive", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("01bbde4d-9a2e-4f90-b05d-0a8f95126caa"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4044), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4045), "Adıyaman" },
                    { new Guid("3d8f80b5-0053-4f9f-9567-d04932548e6e"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4048), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4049), "Ağrı" },
                    { new Guid("4716b89d-3237-4dcf-9901-0318a803ff81"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4050), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4050), "Amasya" },
                    { new Guid("7679f24a-7d29-472c-b674-6431a9ab05f1"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4047), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4047), "Afyon" },
                    { new Guid("cbe7752a-8eaf-4743-a487-4c6e62fb5658"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4052), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4052), "Ankara" },
                    { new Guid("ef7b23b3-39a0-448a-83ed-45eb6a1224da"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4041), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(4042), "Adana" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "DeletedDate", "IsActive", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2b097d52-677d-4915-8be0-1680b14a5010"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3296), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3297), "Expert" },
                    { new Guid("316dfa77-073d-4672-bbf6-5d615575696c"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3305), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3306), "Mod" },
                    { new Guid("664b6c0c-2cdf-46c3-bffe-164b9c6dae86"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3303), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3304), "Admin" },
                    { new Guid("ab230d00-b037-4751-b727-dddc7cd9bb5d"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3300), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3300), "Fish" },
                    { new Guid("c5d62390-65d4-44a3-a134-e1f2e63642dc"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3302), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3302), "Mid" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "DeletedDate", "IsActive", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("23cf33d2-4f95-4a36-973a-b0f6e69ce29d"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3598), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3599), "Otomobil" },
                    { new Guid("974dbdb9-2993-44ef-b57a-1240eb1fb597"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3603), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3604), "Motorsiklet" },
                    { new Guid("d20902d0-022c-4918-8c53-53e267ec4885"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3601), null, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(3601), "Deniz Aracı" }
                });

            migrationBuilder.InsertData(
                table: "BrandVehicleType",
                columns: new[] { "BrandId", "VehicleTypeId" },
                values: new object[,]
                {
                    { new Guid("71bd378a-854f-41a0-b565-2021bdaf1bfb"), new Guid("d20902d0-022c-4918-8c53-53e267ec4885") },
                    { new Guid("8ecbbdb3-50ad-4b66-9baa-1f27298695a7"), new Guid("23cf33d2-4f95-4a36-973a-b0f6e69ce29d") },
                    { new Guid("8ecbbdb3-50ad-4b66-9baa-1f27298695a7"), new Guid("974dbdb9-2993-44ef-b57a-1240eb1fb597") },
                    { new Guid("8efb1d22-30fc-4180-bf39-26ffb23a2428"), new Guid("d20902d0-022c-4918-8c53-53e267ec4885") }
                });

            migrationBuilder.InsertData(
                table: "Finders",
                columns: new[] { "Id", "CityId", "ConfirmEmail", "ConfirmPerson", "CreatedByName", "CreatedDate", "DeletedDate", "Description", "Email", "FirstName", "IsActive", "IsBanned", "LastName", "ModifiedByName", "ModifiedDate", "PasswordHash", "PasswordSalt", "Phone", "RememberMe", "RoleId", "SuccessfulWork", "Tc", "VIP", "Vote" },
                values: new object[,]
                {
                    { new Guid("2394f0d0-07d9-43b5-9095-30c4975f449d"), new Guid("cbe7752a-8eaf-4743-a487-4c6e62fb5658"), true, true, "Samet", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2914), null, "Merhaba bana güvenebilrirsnizi...", "kabadayiabdulsamet@gmail.com", "samet", true, false, "Kabadayı", "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2906), new byte[] { 56, 50, 55, 99, 99, 98, 48, 101, 101, 97, 56, 97, 55, 48, 54, 99, 52, 99, 51, 52, 97, 49, 54, 56, 57, 49, 102, 56, 52, 101, 55, 98 }, new byte[] { 51, 97, 53, 102, 99, 56, 49, 99, 97, 56, 102, 53, 57, 57, 55, 49, 51, 50, 101, 56, 101, 101, 99, 99, 100, 56, 54, 55, 50, 99, 99, 98 }, "5555555555", false, new Guid("316dfa77-073d-4672-bbf6-5d615575696c"), 12, "44444444444", true, 9m },
                    { new Guid("d22c2e26-fc10-4fdc-8a2e-ddcdbdbfba7f"), new Guid("ef7b23b3-39a0-448a-83ed-45eb6a1224da"), false, false, "Samet1", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2925), null, "Merhaba bana güvenebilrirsnizi2...", "sabadayiabdulsamet@gmail.com", "ali", true, false, "veli", "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(2922), new byte[] { 56, 50, 55, 99, 99, 98, 48, 101, 101, 97, 56, 97, 55, 48, 54, 99, 52, 99, 51, 52, 97, 49, 54, 56, 57, 49, 102, 56, 52, 101, 55, 98 }, new byte[] { 51, 97, 53, 102, 99, 56, 49, 99, 97, 56, 102, 53, 57, 57, 55, 49, 51, 50, 101, 56, 101, 101, 99, 99, 100, 56, 54, 55, 50, 99, 99, 98 }, "6555555555", false, new Guid("316dfa77-073d-4672-bbf6-5d615575696c"), 0, "54444444444", false, 9m }
                });

            migrationBuilder.InsertData(
                table: "Seekers",
                columns: new[] { "Id", "CityId", "ConfirmEmail", "ConfirmPerson", "CreatedByName", "CreatedDate", "DeletedDate", "Email", "FirstName", "IsActive", "IsBanned", "LastName", "ModifiedByName", "ModifiedDate", "PasswordHash", "Phone", "RememberMe", "Tc", "VIP" },
                values: new object[,]
                {
                    { new Guid("5b244afb-5101-430f-84f6-f48fafc339d8"), new Guid("01bbde4d-9a2e-4f90-b05d-0a8f95126caa"), true, true, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(949), null, "aliali@gmail", "ali", true, false, "mehmet", "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(932), new byte[] { 98, 101, 51, 97, 51, 98, 97, 100, 53, 48, 101, 55, 48, 51, 99, 99, 98, 99, 102, 97, 102, 100, 55, 52, 100, 55, 48, 97, 48, 57, 49, 50 }, "1111111111", false, "12345678901", true },
                    { new Guid("5eb98805-dc12-45ae-b97d-c97a81a0f0e6"), new Guid("4716b89d-3237-4dcf-9901-0318a803ff81"), false, false, "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(956), null, "veliveli@gmail", "veli", true, false, "ahmet", "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(953), new byte[] { 102, 56, 97, 98, 57, 56, 99, 102, 52, 100, 54, 55, 100, 55, 98, 53, 101, 100, 50, 98, 48, 54, 101, 102, 102, 53, 49, 53, 97, 100, 52, 55 }, "2222222222", false, "22222222222", false }
                });

            migrationBuilder.InsertData(
                table: "Proclamations",
                columns: new[] { "Id", "BrandId", "CityId", "CreatedByName", "CreatedDate", "DeletedDate", "Description", "IsActive", "Link", "ModifiedByName", "ModifiedDate", "ProclamaionPrize", "SeekerId", "VehiclePrize" },
                values: new object[] { new Guid("d4121c85-ee78-41fd-aa7f-dabc74d1536a"), new Guid("8ecbbdb3-50ad-4b66-9baa-1f27298695a7"), new Guid("cbe7752a-8eaf-4743-a487-4c6e62fb5658"), "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(5297), null, "araç yakın", true, "www.ask.com", "empty", new DateTime(2022, 12, 3, 14, 18, 45, 205, DateTimeKind.Local).AddTicks(5293), 1000m, new Guid("5b244afb-5101-430f-84f6-f48fafc339d8"), 3000000m });

            migrationBuilder.CreateIndex(
                name: "IX_BrandVehicleType_VehicleTypeId",
                table: "BrandVehicleType",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Finders_CityId",
                table: "Finders",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Finders_Email",
                table: "Finders",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Finders_Phone",
                table: "Finders",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Finders_RoleId",
                table: "Finders",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Finders_Tc",
                table: "Finders",
                column: "Tc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proclamations_BrandId",
                table: "Proclamations",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Proclamations_CityId",
                table: "Proclamations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Proclamations_SeekerId",
                table: "Proclamations",
                column: "SeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Seekers_CityId",
                table: "Seekers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Seekers_Email",
                table: "Seekers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seekers_Phone",
                table: "Seekers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seekers_Tc",
                table: "Seekers",
                column: "Tc",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandVehicleType");

            migrationBuilder.DropTable(
                name: "Finders");

            migrationBuilder.DropTable(
                name: "Proclamations");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Seekers");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
