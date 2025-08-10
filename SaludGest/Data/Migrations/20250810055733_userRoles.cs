using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludGest.Migrations
{
    /// <inheritdoc />
    public partial class userRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e880f8e-0fe8-4d69-9a1c-537adb2c0165", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "39f8bcbb-bfd0-44ef-85eb-8a62c8b45cb3", 0, "d2fd1482-8571-48b0-901c-889b0a05732f", "admin@saludgest.com", true, false, null, "ADMIN@SALUDGEST.COM", "ADMIN@SALUDGEST.COM", "AQAAAAIAAYagAAAAEN25rpJ+Jw72pLflmQXKJDO4pWAruNTHhF2zrs0qUqkM953V7yhZEFDbYRFX76Bnzg==", null, false, "a9bf894d-f020-4cc5-a507-a09190f10363", false, "admin@saludgest.com" });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 9, 23, 57, 30, 903, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6e880f8e-0fe8-4d69-9a1c-537adb2c0165", "39f8bcbb-bfd0-44ef-85eb-8a62c8b45cb3" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9386));
        }
    }
}
