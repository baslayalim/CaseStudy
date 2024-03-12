namespace CaseStudy.Training.DesignPatterns.Behavioral.interpreter
{
    class BehavioralinterpreterTeamLeadExpression : BehavioralinterpreterIJobExpression
    {
        public void Interpret(BehavioralinterpreterContext context)
        {
            if (context.formula.Contains('L'))
            {
                context.totalPoint += 7000;
            }
        }
    }
}