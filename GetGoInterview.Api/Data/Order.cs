namespace GetGoInterview.Api.Data;

public class Order
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public User? User { get; set; }

    public Driver? Driver { get; set; }
}

public class OrderData
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int UserId { get; set; }

    public int DriverId { get; set; }

    // one or many Orders has one user
    public UserData? User { get; set; }

    // one or many Orders has one driver
    public DriverData? Driver { get; set; }
}