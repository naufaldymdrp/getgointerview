namespace GetGoInterview.Api.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class GetGoInterviewDbContext : DbContext
{
    public GetGoInterviewDbContext(DbContextOptions<GetGoInterviewDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserData>? Users { get; set; }

    public DbSet<DriverData>? Drivers { get; set; }

    public DbSet<OrderData>? Orders { get; set; }

    public DbSet<CarData>? Cars { get; set; }

    public DbSet<Location>? Locations { get; set; }

    public DbSet<Score>? Scores { get; set; }
}