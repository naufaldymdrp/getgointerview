namespace GetGoInterview.Api.Data;

public class Location
{
    public int X { get; set; }

    public int Y { get; set; }

    public DateTime SysCreationDate { get; set; }
}

public class UserLocationData
{
    public int Id { get; set; }

    public bool Status { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public DateTime SysCreationDate { get; set; }

    public int UserId { get; set; }

    public UserData? User { get; set; }
}

public class DriverLocationData
{
    public int Id { get; set; }

    public bool Status { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public DateTime SysCreationDate { get; set; }

    public int DriverId { get; set; }

    public DriverData? Driver { get; set; }
}