namespace QuestionIt.Repositories
{
    public interface ICrudDeleteOperation<T>
    {
        public void Delete(T entity);
    }
}
