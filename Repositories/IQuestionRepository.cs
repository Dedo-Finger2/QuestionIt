using QuestionIt.Entities;

namespace QuestionIt.Repositories
{
    public interface IQuestionRepository : ICrudSaveOperation<QuestionEntity>, ICrudFindOneByIdOperation<QuestionEntity, int>
    {
        public QuestionEntity[] FindAllByQuestionnaireId(int questionnaireId);
    }
}
