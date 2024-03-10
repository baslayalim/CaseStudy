namespace CaseStudy.Training.DesignPatterns.Structural.Flyweight
{
    class StructuralFlyweightBlackBox : StructuralFlyweightBox
    {
        public StructuralFlyweightBlackBox(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.boxColor = StructuralFlyweightBoxColor.Black;
        }

        public override void Draw(int locationX, int locationY)
        {
            Console.WriteLine($"{boxColor} Kutu Cizildi {locationX},{locationY}");
        }
    }
}
