namespace Minnet.Api.Responses;

public class PagedResultResponse<T> : ResultResponse<T>
{
    public PagedResultResponse(T result, uint pageCount) : base(result)
    {
        PageCount = pageCount;
    }

    public uint PageCount { get; private set; }
}
