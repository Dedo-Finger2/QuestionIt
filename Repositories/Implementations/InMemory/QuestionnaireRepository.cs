using QuestionIt.DTOs;
using QuestionIt.Entities;

namespace QuestionIt.Repositories.Implementations.InMemory
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private QuestionnaireEntity[] questionnaires;

        public QuestionnaireRepository()
        {
            this.questionnaires = [];
        }

        private int GetLastInsertedId()
        {
            try
            {
                QuestionnaireEntity lastQuestionnaire = this.questionnaires.Last();

                return lastQuestionnaire.Id;
            } catch (InvalidOperationException e)
            {
                return 0;
            }
        }

        public void DeleteById(int id)
        {
            QuestionnaireEntity[] newArr = [];

            foreach (QuestionnaireEntity entity in this.questionnaires)
            {
                if (entity.Id == id) continue;

                newArr = newArr.Append(entity).ToArray();
            }

            this.questionnaires = newArr;

            return;
        }

        public QuestionnaireJsonDTO ExportToJson(int id)
        {
            QuestionnaireEntity questionnaire = this.questionnaires.Where(q => q.Id == id).First();

            return new(questionnaire.Title, questionnaire.Description, [], questionnaire.CreatedAt, questionnaire.UpdatedAt);
        }

        public QuestionnaireEntity ImportFromJson(QuestionnaireJsonDTO questionnaire)
        {
            int newId = this.GetLastInsertedId() + 1;

            QuestionnaireEntity entity = new(newId, questionnaire.Title, questionnaire.Description, questionnaire.CreatedAt, questionnaire.UpdatedAt);

            this.Save(entity);

            return entity;
        }

        public QuestionnaireEntity[] FindAll()
        {
            return this.questionnaires;
        }

        public QuestionnaireEntity? FindOneById(int id)
        {
            foreach (QuestionnaireEntity entity in this.questionnaires)
            {
                if (entity.Id == id) return entity;
            }

            return null;
        }

        public QuestionnaireEntity Save(QuestionnaireEntity entity)
        {
            this.questionnaires = this.questionnaires.Append(entity).ToArray();

            return entity;
        }
    }
}
