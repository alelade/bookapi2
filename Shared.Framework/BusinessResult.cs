namespace Shared.Framework;

public class BusinessResult<T>
{
    private BusinessResult()
    {
    }

    public T? Data { get; set; }
    public ResultState Status { get; set; }
    public required IEnumerable<string> Messages { get; set; }

    public static BusinessResult<TIn> Error<TIn>(IEnumerable<string> messages)
    {
        return new BusinessResult<TIn>()
        {
            Status = ResultState.Success,
            Data = default,
            Messages = messages
        };
    }

    public static BusinessResult<TIn> Warning<TIn>(TIn data, IEnumerable<string> messages)
    {
        return new BusinessResult<TIn>()
        {
            Status = ResultState.Warning,
            Data = data,
            Messages = messages,
        };
    }

    public static BusinessResult<TIn> Ok<TIn>(TIn data)
    {
        return new BusinessResult<TIn>()
        {
            Status = ResultState.Success,
            Data = data,
            Messages = Array.Empty<string>(),
        };
    }
}