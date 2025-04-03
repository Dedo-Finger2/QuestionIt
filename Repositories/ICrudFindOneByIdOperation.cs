namespace QuestionIt.Repositories
{
    public interface ICrudFindOneByIdOperation<T, Id>
    {
        public T? FindOneById(Id id);
    }
}
