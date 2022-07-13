namespace GetGoInterview.Api.Data;

public class Response<T>
{
    public bool RequestStatus { get; set; }

    public T? Data { get; set; }
}