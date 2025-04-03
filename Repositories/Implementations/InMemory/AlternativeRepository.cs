using QuestionIt.Entities;

namespace QuestionIt.Repositories.Implementations.InMemory
{
    public class AlternativeRepository : IAlternativeRepository
    {
        private AlternativeEntity[] alternatives;

        public AlternativeRepository()
        {
            this.alternatives = [];
        }

        public AlternativeEntity[] FindAllByQuestionId(int questionId)
        {
            return this.alternatives.Where(a => a.QuestionId == questionId).ToArray();
        }

        public AlternativeEntity? FindOneById(int id)
        {
            return this.alternatives.Where(a => a.Id == id).First();
        }

        public AlternativeEntity Save(AlternativeEntity entity)
        {
            this.alternatives = this.alternatives.Append(entity).ToArray();

            return entity;
        }
    }
}
