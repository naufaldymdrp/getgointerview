namespace GetGoInterview.Api.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class GetGoInterviewDbContext : DbContext
{
    public GetGoInterviewDbContext(DbContextOptions<GetGoInterviewDbContext> options)
        : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CreateDataModel(modelBuilder);

        SeedData(modelBuilder);
    }

    private static void CreateDataModel(ModelBuilder modelBuilder)
    {
        // master table
        modelBuilder.Entity<CarData>()
            .ToTable("Car")
            .HasOne(car => car.Driver).WithOne(driver => driver.Car)
            .HasForeignKey<DriverData>(driver => driver.CarId);

        // master table
        modelBuilder.Entity<UserData>()
            .ToTable("User");

        modelBuilder.Entity<DriverData>()
            .ToTable("Driver");

        modelBuilder.Entity<OrderData>()
            .ToTable("Order");

        modelBuilder.Entity<ScoreData>()
            .ToTable("Score");

        modelBuilder.Entity<UserLocationData>()
            .ToTable("UserLocation");

        modelBuilder.Entity<DriverLocationData>()
            .ToTable("DriverLocation");
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarData>()
            .HasData(new CarData[] {
                new CarData { Id = 1, Name = "Toyota" },
                new CarData { Id = 2, Name = "Honda" },
                new CarData { Id = 3, Name = "Hyundai" },
                new CarData { Id = 4, Name = "Suzuki" },
                new CarData { Id = 5, Name = "Kia" }
            });

        modelBuilder.Entity<UserData>()
            .HasData(new UserData[] {
                new UserData { Id = 1, Name = "Basuki" },
                new UserData { Id = 2, Name = "Putri" },
                new UserData { Id = 3, Name = "Ayunda" },
                new UserData { Id = 4, Name = "Tomi" },
                new UserData { Id = 5, Name = "Nomad" }
            });

        modelBuilder.Entity<DriverData>()
            .HasData(new DriverData[] {
                new DriverData { Id = 1, }
            });
    }

    public DbSet<UserData>? Users { get; set; }

    public DbSet<DriverData>? Drivers { get; set; }

    public DbSet<OrderData>? Orders { get; set; }

    public DbSet<CarData>? Cars { get; set; }

    public DbSet<ScoreData>? Scores { get; set; }

    public DbSet<UserLocationData>? UserLocations { get; set; }

    public DbSet<DriverLocationData>? DriverLocations { get; set; }
}