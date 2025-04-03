namespace QuestionIt.DTOs
{
    public class QuestionAlternativeJsonDTO
    {
        public string Title { get; private set; }
        public int Correct { get; private set; }

        public QuestionAlternativeJsonDTO() { }

        public QuestionAlternativeJsonDTO(string title, int correct)
        {
            this.Title = title;
            this.Correct = correct;
        }
    }
}
