namespace GetGoInterview.Api.Data;

public class Driver
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Car? Car { get; set; }

    public Order? ActiveOrder { get; set; }

    public Score? ActiveScore { get; set; }

    public Location? ActiveLocation { get; set; }
}

public class DriverData
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public int CarId { get; set; }

    // one driver could only has one car
    public CarData? Car { get; set; }

    // one driver has many orders
    public List<OrderData>? Orders { get; set; }

    // one driver has many scores
    public List<ScoreData>? Scores { get; set; }

    // one driver has many location
    public List<DriverLocationData>? DriverLocations { get; set; }
}