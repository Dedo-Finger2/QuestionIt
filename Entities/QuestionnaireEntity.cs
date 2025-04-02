namespace QuestionIt.Entities
{
    public class QuestionnaireEntity
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public QuestionnaireEntity(string title, string? description)
        {
            this.Title = this.FormatTitle(title);
            this.Description = description;
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = null;
        }

        public QuestionnaireEntity(int id, string title, string? description, DateTime createdAt, DateTime? updatedAt)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        private string FormatTitle(string value)
        {
            string noSpace = value.Trim();
            string firstLetterCaptalized = noSpace[0].ToString().ToUpper();
            return string.Concat(firstLetterCaptalized, noSpace.AsSpan(1));
        }
    }
}
