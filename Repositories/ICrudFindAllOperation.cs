namespace QuestionIt.Repositories
{
    public interface ICrudFindAllOperation<T>
    {
        public T[] FindAll();
    }
}
