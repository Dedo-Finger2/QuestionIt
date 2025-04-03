using QuestionIt.Entities;

namespace QuestionIt.Repositories
{
    public interface IAlternativeRepository : ICrudSaveOperation<AlternativeEntity>, ICrudFindOneByIdOperation<AlternativeEntity, int>
    {
        public AlternativeEntity[] FindAllByQuestionId(int questionId);
    }
}
