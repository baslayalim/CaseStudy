namespace CaseStudy.Training.DesignPatterns.Structural.Flyweight
{
    class StructuralFlyweightBlueBox : StructuralFlyweightBox
    {
        public StructuralFlyweightBlueBox(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.boxColor = StructuralFlyweightBoxColor.Blue;
        }

        public override void Draw(int locationX, int locationY)
        {
            Console.WriteLine($"{boxColor} Kutu Cizildi {locationX},{locationY}");
        }
    }
}
