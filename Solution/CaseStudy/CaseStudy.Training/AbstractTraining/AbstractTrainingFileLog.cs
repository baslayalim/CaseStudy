namespace CaseStudy.Training.AbstractTraining
{
    public class AbstractTrainingFileLog : AbstractTrainingLogBase
    {
        public override void WriteLog()
        {
            Console.WriteLine("File Log yazıldı.");
        }
        public override void WriteErrorLog()
        {
            Console.WriteLine("File Error Log yazıldı.");
        }
    }
}
