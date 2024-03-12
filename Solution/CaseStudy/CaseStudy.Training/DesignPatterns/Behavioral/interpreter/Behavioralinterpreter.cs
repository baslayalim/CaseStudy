namespace CaseStudy.Training.DesignPatterns.Behavioral.interpreter
{
    internal class Behavioralinterpreter
    {
        public static void interpreter()
        {
            BehavioralinterpreterContext context = new BehavioralinterpreterContext();
            context.formula = "GGML";

            BehavioralinterpreterJobManager jobManager = new BehavioralinterpreterJobManager();
            jobManager.RunExpression(context);

            Console.WriteLine($"{context.formula} :> {context.totalPoint}");
        }
    }
}