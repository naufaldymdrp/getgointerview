using Microsoft.EntityFrameworkCore;

namespace GetGoInterview.Api.Data;

public class UserBusiness
{
    private readonly GetGoInterviewDbContext _dbContext;

    public UserBusiness(GetGoInterviewDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Order>? GetOrdersHistory(User user)
    {
        var orders = _dbContext.Users switch
        {
            var list when list is not null =>
                list.Where(userData => userData.Id == user.Id)
                    .First()
                    .Orders!
                    .Select(orderData => new Order
                    {
                        Id = orderData.Id,
                        Name = orderData.Name,
                        Driver = new Driver
                        {
                            Id = orderData.Driver!.Id,
                            Name = orderData.Driver!.Name,
                            Car = new Car
                            {
                                Id = orderData.Driver!.Car!.Id,
                                Name = orderData.Driver!.Car!.Name
                            }
                        },
                    })
                    .ToList(),
            _ => null,
        };

        return orders;
    }
}