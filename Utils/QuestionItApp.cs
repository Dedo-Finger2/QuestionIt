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
        // private QuestionnaireService questionnaireService;
        // private ResultService resultService;

        public QuestionItApp()
        {
            this.questionnaireListCurrentPage = 0;
            this.questionnaireListCurrentPage = 1;
            this.currentQuestionId = 0;
            this.currentQuestionnaireId = 0;
            this.userAnswers = [];
        }

        public void Start()
        {
            string[] menuOptions = { "Listar questionários", "Importar questionário", "Sair" };

            Console.WriteLine(string.Concat(Enumerable.Repeat('=', 25)));
            Console.WriteLine("QuestionIt");
            Console.WriteLine(string.Concat(Enumerable.Repeat('=', 25)));

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

            switch(userChoosenMenuOption.KeyChar)
            {
                case '0': Console.WriteLine("\nListando questionários..."); break;
                case '1': Console.WriteLine("\nMostrnado opção de input do path..."); break;
                case '2': break;
                default: Console.WriteLine("\ninvalid option"); break;
            }
        }

        // TODO: Implement
        private void Stop() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void ListQuestionnaires() { throw new Exception("method not implemented"); }
        // TODO: Implement
        private void ImportQuestionnaireJson() { throw new Exception("method not implemented"); }
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
    }
}
