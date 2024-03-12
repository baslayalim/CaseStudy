namespace CaseStudy.Training.DesignPatterns.Behavioral.interpreter
{ 
    class BehavioralinterpreterJobManager
    {
        public List<BehavioralinterpreterIJobExpression> CreateExpressionTree(string formula)
        {
            List<BehavioralinterpreterIJobExpression> tree = new List<BehavioralinterpreterIJobExpression>();

            foreach (char role in formula)
            {
                switch (role)
                {
                    case 'G':
                        tree.Add(new BehavioralinterpreterDeveloperExpression());
                        break;
                    case 'M':
                        tree.Add(new BehavioralinterpreterAccountingExpression());
                        break;
                    case 'L':
                        tree.Add(new BehavioralinterpreterTeamLeadExpression());
                        break;
                    default:
                        throw new Exception("Unexpected role!");
                }
            }
            return tree;
        }

        public void RunExpression(BehavioralinterpreterContext context)
        {
            foreach (BehavioralinterpreterIJobExpression expression in CreateExpressionTree(context.formula))
            {
                expression.Interpret(context);
            }
        }
    }
}