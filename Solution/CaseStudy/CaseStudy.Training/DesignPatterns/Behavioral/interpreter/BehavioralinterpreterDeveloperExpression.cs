namespace CaseStudy.Training.DesignPatterns.Behavioral.interpreter
{ 
    class BehavioralinterpreterDeveloperExpression : BehavioralinterpreterIJobExpression
    {
        public void Interpret(BehavioralinterpreterContext context)
        {
            if (context.formula.Contains('G'))
            {
                context.totalPoint += 4000;
            }
        }
    }
}