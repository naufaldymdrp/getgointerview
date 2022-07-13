using System.ComponentModel.DataAnnotations.Schema;

namespace GetGoInterview.Api.Data;

public class Car
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Driver? Driver { get; set; }
}

public class CarData
{
    public int Id { get; set; }

    public string? Name { get; set; }

    // one car has one driver
    public DriverData? Driver { get; set; }
}