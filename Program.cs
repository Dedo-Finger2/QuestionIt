using QuestionIt.Entities;
using QuestionIt.Utils;

namespace QuestionIt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            QuestionItApp app = new();

            app.Start();
        }
    }
}