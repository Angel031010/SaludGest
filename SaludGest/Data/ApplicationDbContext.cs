using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaludGest.Models;

namespace SaludGest.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<HistorialMedico> HistorialMedico { get; set; }
        public DbSet<Prescripcion> Prescripciones { get; set; }
        public DbSet<Sala> Salas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Departamentos
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { DepartamentoId = 1, NombreDepartamento = "Cardiología", Ubicacion = "Piso 1" },
                new Departamento { DepartamentoId = 2, NombreDepartamento = "Neurología", Ubicacion = "Piso 2" },
                new Departamento { DepartamentoId = 3, NombreDepartamento = "Pediatría", Ubicacion = "Piso 3" },
                new Departamento { DepartamentoId = 4, NombreDepartamento = "Urgencias", Ubicacion = "Piso 0" },
                new Departamento { DepartamentoId = 5, NombreDepartamento = "Oncología", Ubicacion = "Piso 4" }
            );

            // Especialidades
            modelBuilder.Entity<Especialidad>().HasData(
                new Especialidad { EspecialidadId = 1, NombreEspecialidad = "Cardiólogo", Descripcion = "Especialista en corazón" },
                new Especialidad { EspecialidadId = 2, NombreEspecialidad = "Neurólogo", Descripcion = "Especialista en sistema nervioso" },
                new Especialidad { EspecialidadId = 3, NombreEspecialidad = "Pediatra", Descripcion = "Especialista en niños" },
                new Especialidad { EspecialidadId = 4, NombreEspecialidad = "Oncólogo", Descripcion = "Especialista en cáncer" },
                new Especialidad { EspecialidadId = 5, NombreEspecialidad = "General", Descripcion = "Médico general" }
            );

            // Médicos
            modelBuilder.Entity<Medico>().HasData(
                new Medico { MedicoId = 1, Nombre = "Luis", ApellidoPaterno = "García", ApellidoMaterno = "Soto", Telefono = "5551234561", Email = "lgarcia@saludgest.com", EspecialidadId = 1, DepartamentoId = 1 },
                new Medico { MedicoId = 2, Nombre = "Ana", ApellidoPaterno = "López", ApellidoMaterno = "Díaz", Telefono = "5551234562", Email = "alopez@saludgest.com", EspecialidadId = 2, DepartamentoId = 2 },
                new Medico { MedicoId = 3, Nombre = "Carlos", ApellidoPaterno = "Ramírez", ApellidoMaterno = "Fernández", Telefono = "5551234563", Email = "cramirez@saludgest.com", EspecialidadId = 3, DepartamentoId = 3 },
                new Medico { MedicoId = 4, Nombre = "María", ApellidoPaterno = "Núñez", ApellidoMaterno = "Torres", Telefono = "5551234564", Email = "mnunez@saludgest.com", EspecialidadId = 4, DepartamentoId = 5 },
                new Medico { MedicoId = 5, Nombre = "Pedro", ApellidoPaterno = "Castro", ApellidoMaterno = "Ruiz", Telefono = "5551234565", Email = "pcastro@saludgest.com", EspecialidadId = 5, DepartamentoId = 4 }
            );

            // Pacientes
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente { PacienteId = 1, Nombre = "Juan", ApellidoPaterno = "Pérez", ApellidoMaterno = "Gómez", FechaNacimiento = new DateTime(1990, 1, 1), Genero = "Masculino", Telefono = "5551112221", Email = "juanp@correo.com", Direccion = "Av. Siempre Viva 123", NumeroSeguroSocial = "ABC123456" },
                new Paciente { PacienteId = 2, Nombre = "Laura", ApellidoPaterno = "Martínez", ApellidoMaterno = "Hernández", FechaNacimiento = new DateTime(1985, 5, 10), Genero = "Femenino", Telefono = "5551112222", Email = "lauram@correo.com", Direccion = "Calle Luna 456", NumeroSeguroSocial = "DEF789012" },
                new Paciente { PacienteId = 3, Nombre = "Carlos", ApellidoPaterno = "Gómez", ApellidoMaterno = "López", FechaNacimiento = new DateTime(1978, 3, 20), Genero = "Masculino", Telefono = "5551112223", Email = "carlosg@correo.com", Direccion = "Calle Sol 789", NumeroSeguroSocial = "GHI345678" },
                new Paciente { PacienteId = 4, Nombre = "Elena", ApellidoPaterno = "Torres", ApellidoMaterno = "Ramírez", FechaNacimiento = new DateTime(1992, 7, 15), Genero = "Femenino", Telefono = "5551112224", Email = "elenat@correo.com", Direccion = "Calle Estrella 101", NumeroSeguroSocial = "JKL901234" },
                new Paciente { PacienteId = 5, Nombre = "Diego", ApellidoPaterno = "Sánchez", ApellidoMaterno = "Vega", FechaNacimiento = new DateTime(2000, 12, 5), Genero = "Masculino", Telefono = "5551112225", Email = "diegos@correo.com", Direccion = "Calle Río 202", NumeroSeguroSocial = "MNO567890" }
            );

            // Medicamentos
            modelBuilder.Entity<Medicamento>().HasData(
                new Medicamento { MedicamentoId = 1, Nombre = "Paracetamol", Laboratorio = "Genéricos MX", Presentacion = "Tabletas 500mg" },
                new Medicamento { MedicamentoId = 2, Nombre = "Ibuprofeno", Laboratorio = "Farmacéutica Alfa", Presentacion = "Cápsulas 200mg" },
                new Medicamento { MedicamentoId = 3, Nombre = "Amoxicilina", Laboratorio = "Laboratorios Beta", Presentacion = "Suspensión 250mg" },
                new Medicamento { MedicamentoId = 4, Nombre = "Omeprazol", Laboratorio = "Genéricos MX", Presentacion = "Cápsulas 20mg" },
                new Medicamento { MedicamentoId = 5, Nombre = "Loratadina", Laboratorio = "Pharma Salud", Presentacion = "Tabletas 10mg" }
            );

            // Salas
            modelBuilder.Entity<Sala>().HasData(
                new Sala { SalaId = 1, DepartamentoId = 1, NumeroSala = 101, TipoSala = "Consulta" },
                new Sala { SalaId = 2, DepartamentoId = 2, NumeroSala = 201, TipoSala = "Consulta" },
                new Sala { SalaId = 3, DepartamentoId = 3, NumeroSala = 301, TipoSala = "Emergencia" },
                new Sala { SalaId = 4, DepartamentoId = 4, NumeroSala = 001, TipoSala = "Emergencia" },
                new Sala { SalaId = 5, DepartamentoId = 5, NumeroSala = 401, TipoSala = "Quirófano" }
            );

            // Historial Médico
            modelBuilder.Entity<HistorialMedico>().HasData(
                new HistorialMedico { HistorialMedicoId = 1, PacienteId = 1, FechaRegistro = new DateTime(2025, 1, 15), Diagnostico = "Gripe", Notas = "Reposo y paracetamol" },
                new HistorialMedico { HistorialMedicoId = 2, PacienteId = 2, FechaRegistro = new DateTime(2025, 3, 5), Diagnostico = "Migraña", Notas = "Ibuprofeno cada 8h" },
                new HistorialMedico { HistorialMedicoId = 3, PacienteId = 3, FechaRegistro = new DateTime(2025, 4, 20), Diagnostico = "Alergia", Notas = "Loratadina por 7 días" },
                new HistorialMedico { HistorialMedicoId = 4, PacienteId = 4, FechaRegistro = new DateTime(2025, 5, 12), Diagnostico = "Gastritis", Notas = "Omeprazol en ayunas" },
                new HistorialMedico { HistorialMedicoId = 5, PacienteId = 5, FechaRegistro = new DateTime(2025, 6, 10), Diagnostico = "Infección de garganta", Notas = "Amoxicilina cada 12h" }
            );

            // Prescripciones
            modelBuilder.Entity<Prescripcion>().HasData(
                new Prescripcion { PrescripcionId = 1, HistorialMedicoId = 1, MedicamentoId = 1, Dosis = "500mg", Frecuencia = "Cada 8h", FechaPrescripcion = new DateTime(2025, 1, 15), FechaFin = new DateTime(2025, 1, 20) },
                new Prescripcion { PrescripcionId = 2, HistorialMedicoId = 2, MedicamentoId = 2, Dosis = "200mg", Frecuencia = "Cada 8h", FechaPrescripcion = new DateTime(2025, 3, 5), FechaFin = new DateTime(2025, 3, 10) },
                new Prescripcion { PrescripcionId = 3, HistorialMedicoId = 3, MedicamentoId = 5, Dosis = "10mg", Frecuencia = "Cada 24h", FechaPrescripcion = new DateTime(2025, 4, 20), FechaFin = new DateTime(2025, 4, 27) },
                new Prescripcion { PrescripcionId = 4, HistorialMedicoId = 4, MedicamentoId = 4, Dosis = "20mg", Frecuencia = "Cada 24h", FechaPrescripcion = new DateTime(2025, 5, 12), FechaFin = new DateTime(2025, 5, 19) },
                new Prescripcion { PrescripcionId = 5, HistorialMedicoId = 5, MedicamentoId = 3, Dosis = "250mg", Frecuencia = "Cada 12h", FechaPrescripcion = new DateTime(2025, 6, 10), FechaFin = new DateTime(2025, 6, 17) }
            );

            // Facturas
            modelBuilder.Entity<Factura>().HasData(
                new Factura { FacturaId = 1, PacienteId = 1, FechaEmision = new DateTime(2025, 1, 20), MontoTotal = 150.00m, Estado = "Pagada" },
                new Factura { FacturaId = 2, PacienteId = 2, FechaEmision = new DateTime(2025, 3, 10), MontoTotal = 200.00m, Estado = "Pendiente" },
                new Factura { FacturaId = 3, PacienteId = 3, FechaEmision = new DateTime(2025, 4, 27), MontoTotal = 180.00m, Estado = "Pagada" },
                new Factura { FacturaId = 4, PacienteId = 4, FechaEmision = new DateTime(2025, 5, 19), MontoTotal = 220.00m, Estado = "Cancelada" },
                new Factura { FacturaId = 5, PacienteId = 5, FechaEmision = new DateTime(2025, 6, 17), MontoTotal = 250.00m, Estado = "Pagada" }
            );

            // Citas
            modelBuilder.Entity<Cita>().HasData(
                new Cita { CitaId = 1, FechaHora = new DateTime(2025, 1, 10, 9, 0, 0), MedicoId = 1, PacienteId = 1, Estado = "Completada", Observaciones = "Consulta general" },
                new Cita { CitaId = 2, FechaHora = new DateTime(2025, 3, 3, 11, 30, 0), MedicoId = 2, PacienteId = 2, Estado = "Completada", Observaciones = "Revisión por migraña" },
                new Cita { CitaId = 3, FechaHora = new DateTime(2025, 4, 18, 10, 0, 0), MedicoId = 3, PacienteId = 3, Estado = "Completada", Observaciones = "Consulta por alergia" },
                new Cita { CitaId = 4, FechaHora = new DateTime(2025, 5, 10, 8, 0, 0), MedicoId = 4, PacienteId = 4, Estado = "Completada", Observaciones = "Consulta de seguimiento" },
                new Cita { CitaId = 5, FechaHora = new DateTime(2025, 6, 8, 14, 0, 0), MedicoId = 5, PacienteId = 5, Estado = "Programada", Observaciones = "Primera cita" }
            );

            #region Roles y Usuarios Iniciales

            var adminRoleId = Guid.NewGuid().ToString();
            var adminUserId = Guid.NewGuid().ToString();

            var doctorRoleId = Guid.NewGuid().ToString();
            var doctorUserId = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<ApplicationUser>();

            // Crear rol administrador
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = doctorRoleId,
                    Name = "Doctor",
                    NormalizedName = "DOCTOR"
                }
            );

            // Crear usuario administrador
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminUserId,
                    UserName = "admin@saludgest.com",
                    NormalizedUserName = "ADMIN@SALUDGEST.COM",
                    Email = "admin@saludgest.com",
                    NormalizedEmail = "ADMIN@SALUDGEST.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
                new ApplicationUser
                {
                    Id = doctorUserId,
                    UserName = "doctor@saludgest.com",
                    NormalizedUserName = "DOCTOR@SALUDGEST.COM",
                    Email = "doctor@saludgest.com",
                    NormalizedEmail = "DOCTOR@SALUDGEST.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Doctor123!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                }
            );

            // Asignar rol admin al usuario administrador
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = doctorRoleId,
                    UserId = doctorUserId
                }
            );
        }
            #endregion


        }
    }
