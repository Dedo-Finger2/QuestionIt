namespace QuestionIt.Repositories
{
    public interface ICrudFindOneOperation<T>
    {
        public T? FindOne(T entity);
    }
}
