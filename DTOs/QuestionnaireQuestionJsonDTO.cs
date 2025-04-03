namespace QuestionIt.DTOs
{
    public class QuestionnaireQuestionJsonDTO
    {
        public string Title { get; private set; }
        public QuestionAlternativeJsonDTO[] QuestionAlternatives { get; private set; }

        public QuestionnaireQuestionJsonDTO() { }

        public QuestionnaireQuestionJsonDTO(string title, QuestionAlternativeJsonDTO[] questionAlternatives)
        {
            this.Title = title;
            this.QuestionAlternatives = questionAlternatives;
        }
    }
}
