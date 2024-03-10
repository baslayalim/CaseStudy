namespace CaseStudy.Training.DesignPatterns.Structural.Flyweight
{
    abstract class StructuralFlyweightBox
    {
        public int width;
        public int height;
        public StructuralFlyweightBoxColor boxColor;

        public abstract void Draw(int locationX, int locationY);
    }
}
