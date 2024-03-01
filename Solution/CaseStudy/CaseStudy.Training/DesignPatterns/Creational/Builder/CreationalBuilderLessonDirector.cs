namespace CaseStudy.Training.DesignPatterns.Creational.Builder
{ 
    class CreationalBuilderLessonDirector
    {
        private CreationalBuilderLessonBuilder lessonBuilder;

        public CreationalBuilderLessonDirector(CreationalBuilderLessonBuilder lessonBuilder)
        {
            this.lessonBuilder = lessonBuilder;
        }

        public void Make()
        {
            lessonBuilder.GetLesson();
            lessonBuilder.ApplyDiscount();
            lessonBuilder.AddLessonNote();
        }
    }
}