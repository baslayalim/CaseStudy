namespace CaseStudy.Training.DesignPatterns.Structural.Flyweight
{
    internal class StructuralFlyweight
    {
        public static void Flyweight() 
        {
            StructuralFlyweightBoxFactory boxFactory = new StructuralFlyweightBoxFactory();

            StructuralFlyweightBox blackBox1 = boxFactory.Get(StructuralFlyweightBoxColor.Black);
            StructuralFlyweightBox blackBox2 = boxFactory.Get(StructuralFlyweightBoxColor.Black);
            StructuralFlyweightBox blackBox3 = boxFactory.Get(StructuralFlyweightBoxColor.Black);
            StructuralFlyweightBox blueBox1 = boxFactory.Get(StructuralFlyweightBoxColor.Blue);

            blackBox1.Draw(97, 37);
            blackBox2.Draw(34, 78);
            blackBox3.Draw(74, 193);
            blueBox1.Draw(1, 4);
        }
    }
}
