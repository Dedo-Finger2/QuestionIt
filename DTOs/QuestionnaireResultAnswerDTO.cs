namespace QuestionIt.DTOs
{
    public class QuestionnaireResultAnswerDTO
    {
        public int QuestionId { get; private set; }
        public int UserAnswerId { get; private set; }
        public int CorrectAnswerId { get; private set; }
        public string UserAnswerText { get; private set; }
        public string CorrectAnswerText { get; private set; }
        public string QuestionText { get; private set; }

        public QuestionnaireResultAnswerDTO() { }

        public QuestionnaireResultAnswerDTO(int questionId, int userAnswerId, int correctAnswerId, string userAnswerText, string correctAnswerText, string questionText)
        {
            this.QuestionId = questionId;
            this.UserAnswerId = userAnswerId;
            this.CorrectAnswerId = correctAnswerId; ;
            this.UserAnswerText = userAnswerText;
            this.CorrectAnswerText = correctAnswerText;
            this.QuestionText = questionText;
        }
    }
}
