using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVR_RAMP_Company.Migrations
{
    /// <inheritdoc />
    public partial class Ramp_to_BD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRD_Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRD_SubBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRD_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRD_Price = table.Column<int>(type: "int", nullable: false),
                    PRD_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRD_Date_Launched = table.Column<DateOnly>(type: "date", nullable: false),
                    PRD_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rep_Code = table.Column<int>(type: "int", nullable: false),
                    Rep_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rep_Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Product");

            migrationBuilder.DropTable(
                name: "Tb_Users");
        }
    }
}
