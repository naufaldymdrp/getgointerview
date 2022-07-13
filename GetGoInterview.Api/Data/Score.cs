namespace GetGoInterview.Api.Data;

public class Score
{
    public int Id { get; set; }

    public bool Status { get; set; }

    public string? Name { get; set; }

    public DateTime SysCreationDate { get; set; }

    public int DriverId { get; set; }
}

public class ScoreData
{
    public int Id { get; set; }

    public bool Status { get; set; }

    public string? Name { get; set; }

    public DateTime SysCreationDate { get; set; }

    public int DriverId { get; set; }

    // one or many scores have one driver
    public DriverData? Driver { get; set; }
}