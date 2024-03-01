namespace CaseStudy.Training.DesignPatterns.Creational.Builder
{
    class CreationalBuilderNewStudentLessonBuilder : CreationalBuilderLessonBuilder
    {
        public override void GetLesson()
        {
            lesson = new CreationalBuilderLesson();
            lesson.id = 1;
            lesson.name = "Yapay Zeka - Başlangıç Seviyesinden İleri Seviyeye 10 Dakikada";
            lesson.price = 49.99;
        }

        public override void ApplyDiscount()
        {
            lesson.discountedPrice = lesson.price * 0.5;
            lesson.discountApplied = true;
        }

        public override void AddLessonNote()
        {
            lesson.lessonNote = "Hoş Geldiniz, İndirim Kodunuz Uygulandı !";
        }

        public override CreationalBuilderLesson GetResult()
        {
            return lesson;
        }
    }
}