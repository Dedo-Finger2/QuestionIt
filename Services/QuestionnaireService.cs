using System.Text.Json;
using QuestionIt.DTOs;
using QuestionIt.Entities;
using QuestionIt.Repositories;

namespace QuestionIt.Services
{
    public class QuestionnaireService
    {
        private IQuestionnaireRepository questionnaireRepository;
        private IQuestionRepository questionRepository;
        private IAlternativeRepository alternativeRepository;

        public QuestionnaireService(IQuestionnaireRepository questionnaireRepository, IQuestionRepository questionRepository, IAlternativeRepository alternativeRepository)
        {
            this.questionnaireRepository = questionnaireRepository;
            this.questionRepository = questionRepository;
            this.alternativeRepository = alternativeRepository;
        }

        public void SaveFromJSONFile(string filePath)
        {
            if (filePath.Trim().Length <= 0 || filePath.Trim() == string.Empty) throw new Exception("invalid file path");

            QuestionnaireJsonDTO source = new();

            using (StreamReader r= new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<QuestionnaireJsonDTO>(json);
            }

            QuestionnaireEntity questionnaire = new(source.Title, source.Description);

            QuestionnaireEntity savedQuestionnaire = this.questionnaireRepository.Save(questionnaire);

            foreach (QuestionnaireQuestionJsonDTO jsonQuestion in source.QuestionnaireQuestions)
            {
                QuestionEntity question = new(savedQuestionnaire.Id, jsonQuestion.Title);

                QuestionEntity savedQuestion = this.questionRepository.Save(question);

                foreach (QuestionAlternativeJsonDTO alternativeJson in jsonQuestion.QuestionAlternatives)
                {
                    AlternativeEntity alternative = new(savedQuestion.Id, alternativeJson.Title, alternativeJson.Correct);

                    this.alternativeRepository.Save(alternative);
                }
            }
        }

        public void ListQuestionnaires()
        {
            return;
        }
    }
}
