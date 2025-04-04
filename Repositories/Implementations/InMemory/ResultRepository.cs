using QuestionIt.DTOs;
using QuestionIt.Entities;

namespace QuestionIt.Repositories.Implementations.InMemory
{
    public class ResultRepository : IResultRepository
    {
        private ResultEntity[] results;

        public ResultRepository()
        {
            this.results = [];
        }

        public ResultEntity[] FindAllByQuestionnaireId(int questionnaireId)
        {
            return this.results.Where(r => r.QuestionnaireId == questionnaireId).ToArray();
        }

        public ResultEntity? FindOneById(int id)
        {
            return this.results.Where(r => r.Id == id).ToArray().Length == 0 ? null : this.results.Where(r => r.Id == id).First();
        }

        public ResultEntity Save(ResultEntity entity)
        {
            this.results = this.results.Append(entity).ToArray();

            return entity;
        }
    }
}
