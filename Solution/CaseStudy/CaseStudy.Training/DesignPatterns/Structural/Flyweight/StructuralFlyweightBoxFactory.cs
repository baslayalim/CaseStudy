namespace CaseStudy.Training.DesignPatterns.Structural.Flyweight
{
    class StructuralFlyweightBoxFactory
    {
        private Dictionary<StructuralFlyweightBoxColor, StructuralFlyweightBox> _boxes;

        public StructuralFlyweightBoxFactory()
        {
            _boxes = new Dictionary<StructuralFlyweightBoxColor, StructuralFlyweightBox>();
        }

        public StructuralFlyweightBox Get(StructuralFlyweightBoxColor boxColor)
        {
            if (_boxes.ContainsKey(boxColor))
            {
                return _boxes[boxColor];
            }

            if (boxColor == StructuralFlyweightBoxColor.Black)
            {
                StructuralFlyweightBox boxBlack = new StructuralFlyweightBlackBox(20, 20);
                _boxes.Add(boxColor, boxBlack); 
                return boxBlack;
            }
            else if (boxColor == StructuralFlyweightBoxColor.Blue)
            {
                StructuralFlyweightBox boxBlue = new StructuralFlyweightBlueBox(20, 20);
                _boxes.Add(boxColor, boxBlue);
                return boxBlue;
            }

            StructuralFlyweightBox box = new StructuralFlyweightBlackBox(20, 20);
            return box;
        }
    }
}