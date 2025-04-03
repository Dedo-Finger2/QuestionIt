namespace QuestionIt.Repositories
{
    public interface ICrudSaveOperation<T>
    {
        public T Save(T entity);
    }
}
