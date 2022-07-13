namespace GetGoInterview.Api.Data;

public class User
{
    public int Id { get; init; }

    public string? Name { get; init; }

    public List<int>? OrderIds { get; set; }

    public int ActiveOrderId { get; set; }

    public int ActiveLocationId { get; set; }
}

public class UserData
{
    public int Id { get; init; }

    public string? Name { get; init; }

    // one user could have many order
    public List<OrderData>? Orders { get; set; }

    // one user could have many location
    public List<UserLocationData>? UserLocations { get; set; }
}