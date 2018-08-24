using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustoProducao.Infrastructure.Migrations
{
    public partial class CriarEstruturaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_EMPRESA",
                columns: table => new
                {
                    ID_EMPRESA = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NR_CNPJ = table.Column<long>(nullable: false),
                    NM_EMPRESA = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EMPRESA", x => x.ID_EMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "TB_INSUMO",
                columns: table => new
                {
                    ID_INSUMO = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CD_INSUMO = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    DT_INSUMO_CADASTRO = table.Column<DateTime>(nullable: false),
                    NM_INSUMO = table.Column<string>(nullable: true),
                    DS_INSUMO = table.Column<string>(nullable: true),
                    VL_INSUMO_NOTA = table.Column<decimal>(type: "DECIMAL (18, 2)", nullable: false),
                    VL_INSUMO_FRETE = table.Column<decimal>(type: "DECIMAL (18, 2)", nullable: false),
                    ID_EMPRESA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_INSUMO", x => x.ID_INSUMO);
                    table.ForeignKey(
                        name: "FK_TB_INSUMO_TB_EMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "TB_EMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_INSUMO_ID_EMPRESA",
                table: "TB_INSUMO",
                column: "ID_EMPRESA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_INSUMO");

            migrationBuilder.DropTable(
                name: "TB_EMPRESA");
        }
    }
}
