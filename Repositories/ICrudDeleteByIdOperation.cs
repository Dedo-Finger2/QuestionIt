namespace QuestionIt.Repositories
{
    public interface ICrudDeleteByIdOperation<T>
    {
        public void DeleteById(T id);
    }
}
