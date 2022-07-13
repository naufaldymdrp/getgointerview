namespace GetGoInterview.Api.Data;

public class Request<T>
{
    public string? RequestId { get; set; }
    public T? Data { get; set; }
}