using System.Text.Json.Serialization;

namespace QuestionIt.DTOs
{
    public class QuestionnaireQuestionJsonDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("alternatives")]
        public QuestionAlternativeJsonDTO[] QuestionAlternatives { get; set; }

        public QuestionnaireQuestionJsonDTO() { }

        public QuestionnaireQuestionJsonDTO(string title, QuestionAlternativeJsonDTO[] questionAlternatives)
        {
            this.Title = title;
            this.QuestionAlternatives = questionAlternatives;
        }
    }
}
