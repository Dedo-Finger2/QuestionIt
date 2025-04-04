using QuestionIt.Entities;
using QuestionIt.Repositories.Implementations.InMemory;
using QuestionIt.Services;
using QuestionIt.Utils;

namespace QuestionIt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            QuestionnaireRepository inMemoryQuestionnaireRepository = new();
            QuestionRepository inMemoryQuestionRepository = new();
            AlternativeRepository inMemoryAlternativeRepository = new();

            QuestionnaireService questionnaireService = new(inMemoryQuestionnaireRepository, inMemoryQuestionRepository, inMemoryAlternativeRepository);
            
            QuestionItApp app = new(questionnaireService);

            app.Start();
        }
    }
}