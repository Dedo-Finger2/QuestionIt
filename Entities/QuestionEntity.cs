namespace QuestionIt.Entities
{
    public class QuestionEntity
    {
        public int Id { get; private set; }
        public int QuestionnaireId { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public QuestionEntity(int questionnaireId, string title)
        {
            this.QuestionnaireId = questionnaireId;
            this.Title = this.FormatTitle(title);
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = null;
        }

        public QuestionEntity(int id, int questionnaireId, string title, DateTime createdAt, DateTime? updatedAt)
        {
            this.Id = id;
            this.QuestionnaireId = questionnaireId;
            this.Title = this.FormatTitle(title);
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public string FormatTitle(string value)
        {
            string noSpaces = value.Trim();
            string firstLetterCapital = noSpaces[0].ToString().ToUpper();
            return string.Concat(firstLetterCapital, noSpaces.AsSpan(1));
        }
    }
}
