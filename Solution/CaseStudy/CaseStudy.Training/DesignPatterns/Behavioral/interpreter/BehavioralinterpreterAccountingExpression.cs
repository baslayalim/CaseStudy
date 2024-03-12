namespace CaseStudy.Training.DesignPatterns.Behavioral.interpreter
{
    class BehavioralinterpreterAccountingExpression : BehavioralinterpreterIJobExpression
    {
        public void Interpret(BehavioralinterpreterContext context)
        {
            if (context.formula.Contains('M'))
            {
                context.totalPoint += 3000;
            }
        }
    }
}