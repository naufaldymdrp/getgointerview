namespace GetGoInterview.Api.Data;

public class User
{
    public int Id { get; init; }

    public string? Name { get; init; }

    public int LocationId { get; set; }

}

public class UserData : User
{
    public Location? Location { get; set; }
}