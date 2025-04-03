namespace QuestionIt.DTOs
{
    public class QuestionnaireDetailedResultDTO
    {
        public string QuestionnaireTitle { get; private set; }
        public QuestionnaireResultAnswerDTO[] QuestionsAndAnswers { get; private set; }
        public int UserPoints { get; private set; }
        public int MaxPoints { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public QuestionnaireDetailedResultDTO() { }
        
        public QuestionnaireDetailedResultDTO(string questionnaireTitle, QuestionnaireResultAnswerDTO[] questionsAndAnswers, int userPoints, int maxPoints, DateTime createdAt)
        {
            this.QuestionnaireTitle = questionnaireTitle;
            this.QuestionsAndAnswers = questionsAndAnswers;
            this.UserPoints = userPoints;
            this.MaxPoints = maxPoints;
            this.CreatedAt = createdAt;
        }
    }
}
