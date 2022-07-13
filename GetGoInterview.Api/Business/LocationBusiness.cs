using Bogus;

namespace GetGoInterview.Api.Data;

/// <summary>
/// Pretends that Class is a service that assigns coordinate from 
/// GPS/Beidou/etc
/// </summary>
public class LocationBusiness
{
    private readonly ILogger<LocationBusiness> _logger;

    private readonly Faker _faker = new();

    public LocationBusiness(ILogger<LocationBusiness> logger)
    {
        _logger = logger;
    }

    public Location AssignLocation() =>
        new()
        {
            X = _faker.Random.Int(min: 1, max: 10),
            Y = _faker.Random.Int(min: 1, max: 10),
            SysCreationDate = DateTime.Now
        };
}