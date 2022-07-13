namespace GetGoInterview.Api.Data;

public class Car
{
    public int Id { get; set; }

    public string? Name { get; set; }
}

public class CarData : Car
{
    public List<DriverData>? Drivers { get; set; }
}