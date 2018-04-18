namespace Query.Core
{
    public interface IQueryBus
    {
        TResult Publish<TQuery, TResult>(TQuery query) where TQuery : IQuery;
    }
}