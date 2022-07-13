namespace GetGoInterview.Api.Data;

public class Score
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int DriverDataId { get; set; }
}

public class ScoreData : Score
{
    public DriverData? Driver { get; set; }
}