using System.Text.Json.Serialization;

namespace QuestionIt.DTOs
{
    public class QuestionAlternativeJsonDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("correct")]
        public int Correct { get; set; }

        public QuestionAlternativeJsonDTO() { }

        public QuestionAlternativeJsonDTO(string title, int correct)
        {
            this.Title = title;
            this.Correct = correct;
        }
    }
}
