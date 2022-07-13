using GetGoInterview.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace GetGoInterview.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserBusiness _userBusiness;

    private readonly ILogger<UserController> _logger;

    public UserController(UserBusiness userBusiness, ILogger<UserController> logger)
    {
        _userBusiness = userBusiness;
        _logger = logger;
    }

    [HttpPost("GetOrderHistory")]
    public Response<List<Order>?> GetOrderHistory(Request<User?> userRequest)
    {
        // _logger.LogInformation()
        var result = _userBusiness.GetOrdersHistory(userRequest.Data!);

        bool status = result switch
        {
            var list when list is null => false,
            _ => true,
        };

        if (status)
            _logger.LogInformation("Data found");
        else
            _logger.LogInformation("Not found");

        return new Response<List<Order>?> { Data = result, RequestStatus = status };
    }
}