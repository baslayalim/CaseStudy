namespace CaseStudy.Training.DesignPatterns.Creational.Builder
{
    internal class CreationalBuilder
    {
        public static void BuildCreate()
        {
            CreationalBuilderLessonBuilder lessonBuilder = new CreationalBuilderOldStudentLessonBuilder();
            CreationalBuilderLessonDirector lessonDirector = new CreationalBuilderLessonDirector(lessonBuilder);
            lessonDirector.Make();
            CreationalBuilderLesson lesson = lessonBuilder.GetResult();

            Console.WriteLine($"{lesson.name} - {lesson.price} - {lesson.discountedPrice}");
            Console.WriteLine($"{lesson.lessonNote}");

            Console.ReadKey();
        }
    }
}