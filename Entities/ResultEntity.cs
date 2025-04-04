namespace QuestionIt.Entities
{
    public class ResultEntity
    {
        public int Id { get; private set; }
        public int QuestionnaireId { get; private set; }
        public int QuestionId { get; private set; }
        public int UserAlternativeId { get; private set; }
        public int CorrectAlternativeId { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public ResultEntity(int questionnaireId, int questionId, int userAlternativeId, int correctAlternativeId)
        {
            this.QuestionnaireId = questionnaireId;
            this.QuestionId = questionId;
            this.UserAlternativeId = userAlternativeId;
            this.CorrectAlternativeId = correctAlternativeId;
            this.CreatedAt = DateTime.UtcNow;
        }

        public ResultEntity(int id, int questionnaireId, int questionId, int userAlternativeId, int correctAlternativeId, DateTime createdAt)
        {
            this.Id = id;
            this.QuestionnaireId = questionnaireId;
            this.QuestionId = questionId;
            this.UserAlternativeId = userAlternativeId;
            this.CorrectAlternativeId = correctAlternativeId;
            this.CreatedAt = createdAt;
        }
    }
}
