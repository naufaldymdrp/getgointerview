namespace GetGoInterview.Api.Data;

public class Driver
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int CarDataId { get; set; }
}

public class DriverData
{
    public List<ScoreData>? Score { get; set; }

    public CarData? Car { get; set; }

    public Location? Location { get; set; }
}