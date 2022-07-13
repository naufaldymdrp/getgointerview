namespace GetGoInterview.Api.Data;

public class Order
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int UserDataId { get; set; }

    public int DriverDataId { get; set; }
}

public class OrderData : Order
{
    public UserData? User { get; set; }

    public DriverData? Driver { get; set; }
}