using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equinox.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPackagingEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellPackaging",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BatchNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CellCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PackageType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OperatorId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PackageDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellPackaging", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModulePackaging",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BatchNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ModuleCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PackCode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PackageType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OperatorId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PackageDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulePackaging", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellPackaging");

            migrationBuilder.DropTable(
                name: "ModulePackaging");
        }
    }
}
