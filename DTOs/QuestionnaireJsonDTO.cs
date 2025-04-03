namespace QuestionIt.DTOs
{
    public class QuestionnaireJsonDTO
    {
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public QuestionnaireQuestionJsonDTO[] QuestionnaireQuestions { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public QuestionnaireJsonDTO() { }

        public QuestionnaireJsonDTO(string title, string? description, QuestionnaireQuestionJsonDTO[] questionnaireQuestions, DateTime createdAt, DateTime? updatedAT)
        {
            this.Title = title;
            this.Description = description;
            this.QuestionnaireQuestions = questionnaireQuestions;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAT;
        }
    }
}
