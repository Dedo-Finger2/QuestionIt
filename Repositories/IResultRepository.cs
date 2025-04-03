using QuestionIt.DTOs;
using QuestionIt.Entities;

namespace QuestionIt.Repositories
{
    public interface IResultRepository : ICrudSaveOperation<ResultEntity>, ICrudFindOneByIdOperation<ResultEntity, int>
    {
        public ResultEntity[] FindAllByQuestionnaireId(int questionnaireId);
        public QuestionnaireDetailedResultDTO ExportAsExcelById(int id);
        public QuestionnaireDetailedResultDTO ExportDetailedResultById(int id);
    }
}
