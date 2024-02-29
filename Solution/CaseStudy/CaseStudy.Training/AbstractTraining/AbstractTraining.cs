namespace CaseStudy.Training.AbstractTraining
{
    public class AbstractTraining
    {
        public static void AbstractTrainingClient()
        {
            AbstractTrainingLogBase sqlLog = new AbstractTrainingSqlLog();
            AbstractTrainingLogBase fileLog = new AbstractTrainingFileLog();

            try
            {
                Console.WriteLine("* Dosya Okundu");
                fileLog.WriteLog();
                throw new Exception();
            }
            catch (Exception)
            {
                fileLog.WriteErrorLog();
            }

            try
            {
                Console.WriteLine("* Sql Insert işlemi başarılı");
                sqlLog.WriteLog();
                throw new Exception();
            }
            catch (Exception)
            {
                sqlLog.WriteErrorLog();
            }
        }
    }
}
