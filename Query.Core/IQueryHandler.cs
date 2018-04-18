namespace Query.Core
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery
    {
        TResult Execute(TQuery query);
    }
}