using QuestionIt.DTOs;
using QuestionIt.Entities;

namespace QuestionIt.Repositories
{
    public interface IQuestionnaireRepository : ICrudSaveOperation<QuestionnaireEntity>, ICrudDeleteByIdOperation<int>, ICrudFindOneByIdOperation<QuestionnaireEntity, int>, ICrudFindAllOperation<QuestionnaireEntity>
    {
        public QuestionnaireEntity ImportFromJson(QuestionnaireJsonDTO questionnaire);
        public QuestionnaireJsonDTO ExportToJson(int id);
    }
}
