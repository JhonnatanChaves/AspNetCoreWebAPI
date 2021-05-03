using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SuperMarket.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FancyName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SocialReason = table.Column<string>(type: "text", nullable: true),
                    Cnpj = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Cpf = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    Observation = table.Column<string>(type: "text", nullable: true),
                    FormOfPayment = table.Column<byte>(type: "smallint", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Observation = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchases_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Cnpj", "FancyName", "SocialReason" },
                values: new object[,]
                {
                    { 1, "12.785.496/0001-23", "Depósito Jaguatirica", null },
                    { 2, "07.663.123/0001-78", "Armazém Central de Anápolis ", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cpf", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "456.123.148-52", "jc@outmail.com", "José Caetano Rodrigues de Freitas", "12345678" },
                    { 2, "058.657.789-12", "roberta@outmail.com", "Roberta Ana Souza Passos", "12345678" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CompanyId", "Description", "FormOfPayment", "Name", "Observation", "Value" },
                values: new object[] { 1, 1, "Mini Compressor Ar 300psi 12v P/ Pneu Carro Moto Bicicleta", (byte)2, "Mini Compressor", "ideal para proporcionar maior praticidade dia - a - dia!", 59f });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "Address", "Date", "Observation", "ProductId", "UserId", "Value", "ZipCode" },
                values: new object[] { 1, "Rua Brigadeiro Jordão, Ipiranga, São Paulo/SP", new DateTime(2021, 5, 3, 9, 54, 12, 913, DateTimeKind.Local).AddTicks(7722), "Pago em 2 vezes", 1, 2, 45f, "4210000" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ProductId",
                table: "Purchases",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
