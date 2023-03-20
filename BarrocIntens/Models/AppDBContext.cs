using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BarrocIntens.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<CustomInvoice> CustomInvoices { get; set; }
        public DbSet<CustomInvoiceProduct> CustomInvoiceProducts { get; set; }
        public DbSet<MaintenanceAppointment> MaintenanceAppointments { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MaintenanceAppointmentWorkOrderProduct> MaintenanceAppointmentWorkOrderProducts { get; set; }
        public DbSet<MaintenanceAppointmentWorkOrder> MaintenanceAppointmentWorkOrders { get; set; }
        public DbSet<LeaseContract> LeaseContracts { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Deze lijn uncommenten voor db logs
            //optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql
                ("server=localhost;database=barroc_intens_app;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Inkoop Gebruiker 1", Username = "inkoop1", Password = "pass", RoleId = 1 },
                new User { Id = 2, Name = "Inkoop Gebruiker 2", Username = "inkoop2", Password = "pass", RoleId = 1 },
                new User { Id = 3, Name = "Inkoop manager 3", Username = "inkoop3", Password = "pass", RoleId = 1, isManager = true },
                new User { Id = 4, Name = "Maintenance Gebruiker 1", Username = "maintenance1", Password = "pass", RoleId = 2 },
                new User { Id = 5, Name = "Maintenance Gebruiker 2", Username = "maintenance2", Password = "pass", RoleId = 2 },
                new User { Id = 6, Name = "Maintenance manager 3", Username = "maintenance3", Password = "pass", RoleId = 2, isManager = true },
                new User { Id = 7, Name = "Sales Gebruiker 1", Username = "sales1", Password = "pass", RoleId = 3 },
                new User { Id = 8, Name = "Sales Gebruiker 2", Username = "sales2", Password = "pass", RoleId = 3 },
                new User { Id = 9, Name = "Sales manager 3", Username = "sales3", Password = "pass", RoleId = 3, isManager = true },
                new User { Id = 10, Name = "Finance Gebruiker 1", Username = "finance1", Password = "pass", RoleId = 4 },
                new User { Id = 11, Name = "Finance Gebruiker 2", Username = "finance2", Password = "pass", RoleId = 4 },
                new User { Id = 12, Name = "Finance manager 3", Username = "finance3", Password = "pass", RoleId = 4, isManager = true }
            );

            modelBuilder.Entity<Role>().HasData(
                    new Role { Id = 1, Name = "Inkoop", },
                    new Role { Id = 2, Name = "Maintenance", },
            new Role { Id = 3, Name = "Sales", },
            new Role { Id = 4, Name = "Finance", }
            );
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Bedrijf 1", Street = "Bredaweg", HouseNumber = "23", City = "Breda", CountryCode = "NL", ContactName = "Jan Bedrijfsel", ContactPhoneNumber = "+31618476837" },
                new Company { Id = 2, Name = "Bedrijf 2", Street = "Tilburgweg", HouseNumber = "55", City = "Tilburg", CountryCode = "NL", BkrCheckedAt = new DateTime(2021, 07, 19), ContactName = "Piet Bar", ContactPhoneNumber = "0638561212" },
                new Company { Id = 3, Name = "Bedrijf 3", Street = "Ja", HouseNumber = "1", City = "Antwerpen", CountryCode = "BE", BkrCheckedAt = new DateTime(2020, 01, 10), ContactName = "Belg Jat", ContactPhoneNumber = "+3165847643" },
                new Company { Id = 4, Name = "Adam B.V.", Street = "Adamstraat", HouseNumber = "69", City = "Adamwerpen", CountryCode = "BE", ContactName = "Adam", ContactPhoneNumber = "06adam" }
            );

            modelBuilder.Entity<CustomInvoice>().HasData(
                new CustomInvoice { Id = 1, Date = new DateTime(2022, 03, 22), PaidAt = new DateTime(2022, 03, 23), CompanyId = 1 },
                new CustomInvoice { Id = 2, Date = new DateTime(2021, 11, 01), PaidAt = new DateTime(2021, 11, 05), CompanyId = 1 },
                new CustomInvoice { Id = 3, Date = new DateTime(2022, 06, 11), PaidAt = new DateTime(2022, 06, 11), CompanyId = 2 }
            );

            modelBuilder.Entity<CustomInvoiceProduct>().HasData(
                new CustomInvoiceProduct { Id = 1, ProductId = 2, Amount = 3 },
                new CustomInvoiceProduct { Id = 2, ProductId = 1, Amount = 5 },
                new CustomInvoiceProduct { Id = 3, ProductId = 8, Amount = 4 },
                new CustomInvoiceProduct { Id = 4, ProductId = 4, Amount = 3 },
                new CustomInvoiceProduct { Id = 5, ProductId = 6, Amount = 2 },
                new CustomInvoiceProduct { Id = 6, ProductId = 8, Amount = 8 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Barroc Intens Italian Light", Description = "S234FREKT", ImagePath = "Image/machine-bit-light.png", Price = 499, Stock = 10, ProductCategoryId = 1, IsLeasable = true },
                new Product { Id = 2, Name = "Barroc Intens Italian", Description = "S234KNDPF", ImagePath = "Image/machine-bit-light.png", Price = 599, Stock = 5, ProductCategoryId = 1, IsLeasable = true },
                new Product { Id = 3, Name = "Barroc Intens Italian Deluxe", Description = "S234KNDPF", ImagePath = "Image/machine-bit-deluxe.png", Price = 799, Stock = 7, ProductCategoryId = 1, IsLeasable = true },
                new Product { Id = 4, Name = "Barroc Intens Italian Deluxe Special", Description = "S234NNBMV", ImagePath = "Image/machine-bit-deluxe.png", Price = 999, Stock = 0, ProductCategoryId = 1, IsLeasable = true },
                new Product { Id = 5, Name = "Espresso Beneficio", Description = "S239KLIUP", Price = 21.60m, Stock = 0, ProductCategoryId = 2 },
                new Product { Id = 6, Name = "Yellow Bourbon Brasil", Description = "S239MNKLL", Price = 23.20m, Stock = 250, ProductCategoryId = 2 },
                new Product { Id = 7, Name = "Espresso Roma", Description = "S239IPPSD", Price = 20.80m, Stock = 124, ProductCategoryId = 2 },
                new Product { Id = 8, Name = "Red Honey Honduras", Description = "S239EVVFS", Price = 27.80m, Stock = 121, ProductCategoryId = 2 },
                new Product { Id = 9, Name = "Kabel", Description = "123", Price = 0.05m, Stock = 1000, ProductCategoryId = 1, isPart = true },
                new Product { Id = 10, Name = "Schroef", Description = "SFE8912SD", Price = 0.05m, Stock = 1500, ProductCategoryId = 1, isPart = true },
                new Product { Id = 11, Name = "Lichtje", Description = "GMGE2222A", Price = 0.05m, Stock = 1000, ProductCategoryId = 1, isPart = true },
                new Product { Id = 12, Name = "Knop", Description = "GHSM333A3", Price = 0.05m, Stock = 500, ProductCategoryId = 1, isPart = true }
            );

            modelBuilder.Entity<MaintenanceAppointment>().HasData(
                new MaintenanceAppointment { Id = 1, Remark = "Spullen meenemen", NextAppointment = new DateTime(2022, 05, 17, 17, 15, 0), WorkerId = 4, CompanyId = 1, IsRoutine = false, MaintenanceAppointmentWorkOrderId = 1 },
                new MaintenanceAppointment { Id = 2, Remark = "Kan lang duren", NextAppointment = new DateTime(2021, 12, 12, 10, 15, 0), WorkerId = 5, CompanyId = 2, IsRoutine = false, MaintenanceAppointmentWorkOrderId = 2 },
                new MaintenanceAppointment { Id = 3, Remark = "Kleine onderhoud nodig", NextAppointment = new DateTime(2020, 06, 01, 12, 0, 0), LastAppointment = new DateTime(2019, 09, 29), WorkerId = 6, CompanyId = 3, IsRoutine = false, MaintenanceAppointmentWorkOrderId = 3 },
                new MaintenanceAppointment { Id = 4, Remark = "Grote onderhoud", NextAppointment = new DateTime(2023, 02, 12, 17, 15, 0), WorkerId = 4, CompanyId = 1, IsRoutine = false },
                new MaintenanceAppointment { Id = 5, Remark = "Check", NextAppointment = new DateTime(2024, 02, 12, 17, 13, 0), WorkerId = 4, CompanyId = 1, IsRoutine = true }
            );

            modelBuilder.Entity<MaintenanceAppointmentWorkOrder>().HasData(
                new MaintenanceAppointmentWorkOrder { Id = 1, Description = "ja" },
                new MaintenanceAppointmentWorkOrder { Id = 2, Description = "werk" },
                new MaintenanceAppointmentWorkOrder { Id = 3, Description = "ttt" }
            );
            modelBuilder.Entity<MaintenanceAppointmentWorkOrderProduct>().HasData(
                new MaintenanceAppointmentWorkOrderProduct { Id = 1, MaintenanceAppointmentWorkOrderId = 1, ProductId = 1, Amount = 3 },
                new MaintenanceAppointmentWorkOrderProduct { Id = 2, MaintenanceAppointmentWorkOrderId = 1, ProductId = 2, Amount = 5 },
                new MaintenanceAppointmentWorkOrderProduct { Id = 3, MaintenanceAppointmentWorkOrderId = 2, ProductId = 1, Amount = 2 },
                new MaintenanceAppointmentWorkOrderProduct { Id = 4, MaintenanceAppointmentWorkOrderId = 3, ProductId = 1, Amount = 6 },
                new MaintenanceAppointmentWorkOrderProduct { Id = 5, MaintenanceAppointmentWorkOrderId = 3, ProductId = 1, Amount = 1 },
                new MaintenanceAppointmentWorkOrderProduct { Id = 6, MaintenanceAppointmentWorkOrderId = 3, ProductId = 2, Amount = 3 },
                new MaintenanceAppointmentWorkOrderProduct { Id = 7, MaintenanceAppointmentWorkOrderId = 3, ProductId = 3, Amount = 2 }


            );

            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, NoteText = "Goed gesprek", Date = new DateTime(2022, 01, 22), CompanyId = 1, AuthorId = 8 },
                new Note { Id = 2, NoteText = "Matig gesprek", Date = new DateTime(2021, 07, 15), CompanyId = 2, AuthorId = 7 },
                new Note { Id = 3, NoteText = "Goed gesprek", Date = new DateTime(2020, 01, 05), CompanyId = 3, AuthorId = 8 }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 1, Name = "Machines", IsEmployeeOnly = 1 },
                new ProductCategory { Id = 2, Name = "Koffiebonen", IsEmployeeOnly = 1 }
            );

            modelBuilder.Entity<LeaseContract>().HasData(
                new LeaseContract { Id = 1, Monthly = true, ProductId = 1, CompanyId = 1, StartDate = new DateTime(2022, 08, 10), Periods = 12 },
                new LeaseContract { Id = 2, Monthly = true, ProductId = 2, CompanyId = 1, StartDate = new DateTime(2022, 08, 09), Periods = 12 },
                new LeaseContract { Id = 3, Monthly = false, ProductId = 3, CompanyId = 2, StartDate = new DateTime(2022, 07, 08), Periods = 4 },
                new LeaseContract { Id = 4, Monthly = false, ProductId = 4, CompanyId = 2, StartDate = new DateTime(2022, 06, 07), Periods = 4 },
                new LeaseContract { Id = 5, Monthly = true, ProductId = 2, CompanyId = 1, StartDate = new DateTime(2022, 06, 06), Periods = 12 }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, ProductId = 1, Amount = 200, hasArrived = true },
                new Order { Id = 2, ProductId = 2, Amount = 300, hasArrived = false }
            );
        }
    }
}
