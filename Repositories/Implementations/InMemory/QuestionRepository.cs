using QuestionIt.Entities;

namespace QuestionIt.Repositories.Implementations.InMemory
{
    public class QuestionRepository : IQuestionRepository
    {
        private QuestionEntity[] questions;

        public QuestionRepository()
        {
            this.questions = [];
        }

        public QuestionEntity[] FindAllByQuestionnaireId(int questionnaireId)
        {
            return this.questions.Where(q => q.QuestionnaireId == questionnaireId).ToArray();
        }

        public QuestionEntity? FindOneById(int id)
        {
            return this.questions.Where(q => q.Id == id).First();
        }

        public QuestionEntity Save(QuestionEntity entity)
        {
            this.questions = this.questions.Append(entity).ToArray();

            return entity;
        }
    }
}
