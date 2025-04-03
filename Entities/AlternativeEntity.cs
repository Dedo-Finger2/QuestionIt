namespace QuestionIt.Entities
{
    public class AlternativeEntity
    {
        public int Id { get; private set; }
        public int QuestionId { get; private set; }
        public string Title { get; private set; }
        public int Correct { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public AlternativeEntity(int questionId, string title, int correct)
        {
            this.QuestionId = questionId;
            this.Title = this.FormatTitle(title);
            this.Correct = correct;
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = null;
        }

        public AlternativeEntity(int id, int questionId, string title, int correct, DateTime createdAt, DateTime? updatedAt)
        {
            this.Id = id;
            this.QuestionId = questionId;
            this.Title = this.FormatTitle(title);
            this.Correct = correct;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public string FormatTitle(string value)
        {
            string noSpaces = value.Trim();

            string[] titleWords = noSpaces.Split(" ");
            IEnumerable<string> titleWordsCapital = [];

            foreach (string word in titleWords)
            {
                titleWordsCapital = titleWordsCapital.Append($"{word[0].ToString().ToUpper()}{word.AsSpan(1)}");
            }

            return string.Join(" ", titleWordsCapital);
        }
    }
}
