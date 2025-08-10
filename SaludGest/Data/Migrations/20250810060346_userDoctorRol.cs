using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGest.Migrations
{
    /// <inheritdoc />
    public partial class userDoctorRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e880f8e-0fe8-4d69-9a1c-537adb2c0165", "39f8bcbb-bfd0-44ef-85eb-8a62c8b45cb3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e880f8e-0fe8-4d69-9a1c-537adb2c0165");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39f8bcbb-bfd0-44ef-85eb-8a62c8b45cb3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75f458e1-0069-40e8-b778-b33a89bf231a", null, "Doctor", "DOCTOR" },
                    { "e3294a24-568b-492f-8689-a90d5fd16796", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ca8bb2f-e7d3-4736-80c1-7e967c3175c7", 0, "17018fd9-bbeb-4d93-bf37-6740aa9ac620", "doctor@saludgest.com", true, false, null, "DOCTOR@SALUDGEST.COM", "DOCTOR@SALUDGEST.COM", "AQAAAAIAAYagAAAAEH41P1QC1OfD/O5TkeG3MQzTc/vVt3HiZLmeP0PFO7MTd/6njFQppJa9SkQmy2vwsQ==", null, false, "f06f4e51-1140-41c6-9c36-e0747b4c3b54", false, "doctor@saludgest.com" },
                    { "ca256d5b-cbe8-485c-a04b-d1292c34f1d6", 0, "9838b58d-e24b-42c5-8ae6-7d6c9d7e1e8a", "admin@saludgest.com", true, false, null, "ADMIN@SALUDGEST.COM", "ADMIN@SALUDGEST.COM", "AQAAAAIAAYagAAAAEFQxkRSuCU9F0Si6L1BzBkSKO20TnWz2JWu3n6aoqOf3dNz0+PcWiOYgr+vhGkHz6A==", null, false, "71b87c03-1521-41f3-ac2c-2a992b78ecc9", false, "admin@saludgest.com" }
                });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 10, 0, 3, 44, 196, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "75f458e1-0069-40e8-b778-b33a89bf231a", "1ca8bb2f-e7d3-4736-80c1-7e967c3175c7" },
                    { "e3294a24-568b-492f-8689-a90d5fd16796", "ca256d5b-cbe8-485c-a04b-d1292c34f1d6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75f458e1-0069-40e8-b778-b33a89bf231a", "1ca8bb2f-e7d3-4736-80c1-7e967c3175c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e3294a24-568b-492f-8689-a90d5fd16796", "ca256d5b-cbe8-485c-a04b-d1292c34f1d6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75f458e1-0069-40e8-b778-b33a89bf231a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3294a24-568b-492f-8689-a90d5fd16796");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ca8bb2f-e7d3-4736-80c1-7e967c3175c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca256d5b-cbe8-485c-a04b-d1292c34f1d6");

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
        }
    }
}
