namespace CaseStudy.Training.DesignPatterns.Creational.Builder
{
    abstract class CreationalBuilderLessonBuilder
    {
        public CreationalBuilderLesson lesson;

        public abstract void GetLesson();
        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract CreationalBuilderLesson GetResult();
    }
}