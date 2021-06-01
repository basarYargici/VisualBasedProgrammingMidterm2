namespace HW_8._8
{
    class Square
    {
        private double _side;

        public double Side { get => _side; set => _side = value; }

        public Square()
        {
        }

        public Square(double Side)
        {
            this.Side = Side;
        }

        public override string ToString()
        {
            return "Square side = " + _side;
        }
    }

}
