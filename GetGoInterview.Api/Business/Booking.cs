using GetGoInterview.Api.Data;

namespace GetGoInterview.Api.Business;

public class Booking
{
    private readonly GetGoInterviewDbContext _dbContext;

    public Booking(GetGoInterviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

}