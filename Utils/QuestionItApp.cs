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
    }
}
