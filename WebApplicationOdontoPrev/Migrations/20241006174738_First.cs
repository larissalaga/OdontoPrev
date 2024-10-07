using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationOdontoPrev.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ODTP_DENTISTA",
                columns: table => new
                {
                    id_dentista = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_dentista = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    ds_doc_identificacao = table.Column<string>(type: "NVARCHAR2(14)", maxLength: 14, nullable: false),
                    nr_telefone = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    ds_email = table.Column<string>(type: "NVARCHAR2(70)", maxLength: 70, nullable: false),
                    ds_cro = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_DENTISTA", x => x.id_dentista);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_PERGUNTAS",
                columns: table => new
                {
                    id_pergunta = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ds_pergunta = table.Column<string>(type: "NVARCHAR2(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_PERGUNTAS", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_PLANO",
                columns: table => new
                {
                    id_plano = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_plano = table.Column<string>(type: "NVARCHAR2(60)", maxLength: 60, nullable: false),
                    ds_codigo_plano = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_PLANO", x => x.id_plano);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_PACIENTE",
                columns: table => new
                {
                    id_paciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_paciente = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    nr_cpf = table.Column<string>(type: "NVARCHAR2(11)", maxLength: 11, nullable: false),
                    nr_telefone = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    ds_email = table.Column<string>(type: "NVARCHAR2(70)", maxLength: 70, nullable: false),
                    dt_nascimento = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    ds_sexo = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: false),
                    IdPlano = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_PACIENTE", x => x.id_paciente);
                    table.ForeignKey(
                        name: "FK_T_ODTP_PACIENTE_T_ODTP_PLANO_IdPlano",
                        column: x => x.IdPlano,
                        principalTable: "T_ODTP_PLANO",
                        principalColumn: "id_plano",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_EXTRATO_PONTOS",
                columns: table => new
                {
                    id_extrato_pontos = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dt_extrato = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    nr_numero_pontos = table.Column<int>(type: "NUMBER(10)", maxLength: 10, nullable: false),
                    ds_movimentacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IdPaciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_EXTRATO_PONTOS", x => x.id_extrato_pontos);
                    table.ForeignKey(
                        name: "FK_T_ODTP_EXTRATO_PONTOS_T_ODTP_PACIENTE_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "T_ODTP_PACIENTE",
                        principalColumn: "id_paciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_RAIO_X",
                columns: table => new
                {
                    id_raio_x = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ds_raio_x = table.Column<byte[]>(type: "RAW(2000)", nullable: false),
                    dt_data_raio_x = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    IdPaciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_RAIO_X", x => x.id_raio_x);
                    table.ForeignKey(
                        name: "FK_T_ODTP_RAIO_X_T_ODTP_PACIENTE_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "T_ODTP_PACIENTE",
                        principalColumn: "id_paciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_RESPOSTAS",
                columns: table => new
                {
                    id_resposta = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ds_resposta = table.Column<string>(type: "NVARCHAR2(400)", maxLength: 400, nullable: false),
                    dt_data_resposta = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    IdPergunta = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IdPaciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_RESPOSTAS", x => x.id_resposta);
                    table.ForeignKey(
                        name: "FK_T_ODTP_RESPOSTAS_T_ODTP_PACIENTE_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "T_ODTP_PACIENTE",
                        principalColumn: "id_paciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ODTP_RESPOSTAS_T_ODTP_PERGUNTAS_IdPergunta",
                        column: x => x.IdPergunta,
                        principalTable: "T_ODTP_PERGUNTAS",
                        principalColumn: "id_pergunta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ODTP_ANALISE_RAIO_X",
                columns: table => new
                {
                    id_analise_raio_x = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    id_paciente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ds_analise_raio_x = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    IdRaioX = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    RaioXIdRaioX = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ODTP_ANALISE_RAIO_X", x => x.id_analise_raio_x);
                    table.ForeignKey(
                        name: "FK_T_ODTP_ANALISE_RAIO_X_T_ODTP_RAIO_X_RaioXIdRaioX",
                        column: x => x.RaioXIdRaioX,
                        principalTable: "T_ODTP_RAIO_X",
                        principalColumn: "id_raio_x");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ODTP_ANALISE_RAIO_X_RaioXIdRaioX",
                table: "T_ODTP_ANALISE_RAIO_X",
                column: "RaioXIdRaioX");

            migrationBuilder.CreateIndex(
                name: "IX_T_ODTP_EXTRATO_PONTOS_IdPaciente",
                table: "T_ODTP_EXTRATO_PONTOS",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_T_ODTP_PACIENTE_IdPlano",
                table: "T_ODTP_PACIENTE",
                column: "IdPlano");

            migrationBuilder.CreateIndex(
                name: "IX_T_ODTP_RAIO_X_IdPaciente",
                table: "T_ODTP_RAIO_X",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_T_ODTP_RESPOSTAS_IdPaciente",
                table: "T_ODTP_RESPOSTAS",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_T_ODTP_RESPOSTAS_IdPergunta",
                table: "T_ODTP_RESPOSTAS",
                column: "IdPergunta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ODTP_ANALISE_RAIO_X");

            migrationBuilder.DropTable(
                name: "T_ODTP_DENTISTA");

            migrationBuilder.DropTable(
                name: "T_ODTP_EXTRATO_PONTOS");

            migrationBuilder.DropTable(
                name: "T_ODTP_RESPOSTAS");

            migrationBuilder.DropTable(
                name: "T_ODTP_RAIO_X");

            migrationBuilder.DropTable(
                name: "T_ODTP_PERGUNTAS");

            migrationBuilder.DropTable(
                name: "T_ODTP_PACIENTE");

            migrationBuilder.DropTable(
                name: "T_ODTP_PLANO");
        }
    }
}
