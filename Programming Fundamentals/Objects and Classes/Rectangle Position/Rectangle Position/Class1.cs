namespace Rectangle_Position
{
    class Rectangle
    {
        public double Top { get; set; }

        public double Left { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Right => Left + Width;

        public double Bottom => Top + Height;
    }
}
