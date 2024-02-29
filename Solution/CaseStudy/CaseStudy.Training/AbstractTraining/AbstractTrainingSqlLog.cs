namespace CaseStudy.Training.AbstractTraining
{ 
    public class AbstractTrainingSqlLog : AbstractTrainingLogBase
    {
        public override void WriteLog()
        {
            Console.WriteLine("Sql Log yazıldı..");
        }

        public override void WriteErrorLog()
        {
            Console.Write("Sql Error Log yazıldı.");
        }
    }
}
