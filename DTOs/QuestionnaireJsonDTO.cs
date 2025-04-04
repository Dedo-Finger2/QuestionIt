using System.Text.Json.Serialization;

namespace QuestionIt.DTOs
{
    public class QuestionnaireJsonDTO
    {
        [JsonPropertyName("questionnaireTitle")]
        public string Title { get; set; }
        [JsonPropertyName("questionnaireDescription")]
        public string? Description { get; set; }
        [JsonPropertyName("questions")]
        public QuestionnaireQuestionJsonDTO[] QuestionnaireQuestions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

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
