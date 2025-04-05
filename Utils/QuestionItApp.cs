using QuestionIt.Entities;
using QuestionIt.Services;

namespace QuestionIt.Utils
{
    public class QuestionItApp
    {
        private int questionnaireListPerPage;
        private int questionnaireListCurrentPage;
        private int currentQuestionId;
        private int currentQuestionnaireId;
        private int[] userAnswers;
        // TODO: Implement
         private QuestionnaireService questionnaireService;
        // private ResultService resultService;

        public QuestionItApp(QuestionnaireService questionnaireService)
        {
            this.questionnaireListCurrentPage = 0;
            this.questionnaireListCurrentPage = 1;
            this.currentQuestionId = 0;
            this.currentQuestionnaireId = 0;
            this.userAnswers = [];
            this.questionnaireService = questionnaireService;
        }

        public void Start()
        {
            this.ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            string[] menuOptions = { "Listar questionários", "Importar questionário", "Sair" };

            this.ShowTitle("QuestionIt");

            Console.WriteLine();

            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.Write($"[{i}] {menuOptions[i]}\t");
            }

            bool userChoosenMenuOptionIsDigit;
            int userChoosenMenuOptionIntParsed;
            ConsoleKeyInfo userChoosenMenuOption;

            Console.WriteLine();

            do
            {
                Console.Write("\nInput: ");
                userChoosenMenuOption = Console.ReadKey();

                userChoosenMenuOptionIsDigit = int.TryParse(userChoosenMenuOption.KeyChar.ToString(), out userChoosenMenuOptionIntParsed);
            } while (!userChoosenMenuOptionIsDigit || userChoosenMenuOptionIntParsed > 2 || userChoosenMenuOptionIntParsed < 0);

            switch (userChoosenMenuOption.KeyChar)
            {
                case '0': this.ListQuestionnaires(); break;
                case '1': this.ImportQuestionnaireJson(); break;
                case '2': break;
                default: Console.WriteLine("\ninvalid option"); break;
            }
        }

        // TODO: Implement
        private void Stop() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void ListQuestionnaires()
        {
            Console.Clear();

            this.ShowTitle("Questionnaires List");

            QuestionnaireEntity[] questionnaires = this.questionnaireService.GetAll();

            foreach (QuestionnaireEntity questionnaire in questionnaires)
            {
                Console.WriteLine($"{questionnaire.Id} | {questionnaire.Title}");
            }
        }
        
        private void ImportQuestionnaireJson()
        {
            try
            {
                Console.Clear();

                this.ShowTitle("Importing questionnaire");

                Console.Write("Path: ");
                string jsonFilePath = Console.ReadLine();

                this.questionnaireService.SaveFromJSONFile(jsonFilePath);

                Console.Clear();

                this.ShowMainMenu();
            } catch (Exception e)
            {
                this.ImportQuestionnaireJson();
            }
        }

        // TODO: Implement
        private void NextQuestionnaireListPage() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void PreviousQuestionnaireListPage() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void SelectQuestionnaire() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void StartQuestionnaire() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void NextQuestion() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void GenerateQuestionnaireResultsExcelReport() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void DeleteQuestionnaire() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void GenerateSimpleResultsReport() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void GenerateDetailedResultPDF() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void RedoQuestionnaire() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void ExportQuestionnaireJson() { throw new Exception("method not implemented"); }

        private void ShowTitle(string title)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat('=', 25)));
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat('=', 25)));
        }
    }
}
