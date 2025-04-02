namespace QuestionIt.Entities
{
    public class QuestionnaireEntity
    {
        private int id { get; }
        private string title { get; }
        private string? description { get; }
        private DateTime createdAt { get; }
        private DateTime? updatedAt { get; }

        public QuestionnaireEntity(string title, string? description)
        {
            this.title = this.FormatTitle(title);
            this.description = description;
            this.createdAt = DateTime.UtcNow;
            this.updatedAt = null;
        }

        public QuestionnaireEntity(int id, string title, string? description, DateTime createdAt, DateTime? updatedAt)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }

        private string FormatTitle(string value)
        {
            string noSpace = value.Trim();
            string firstLetterCaptalized = noSpace[0].ToString().ToUpper();
            return string.Concat(firstLetterCaptalized, noSpace.AsSpan(1));
        }
    }
}
