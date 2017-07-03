namespace Rectangle_Intersection
{
    public class Rectangle
    {
        public Rectangle(string id, int width, int height, int x, int y)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = x;
            this.TopLeftY = y;
        }

        public string ID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int TopLeftX { get; set; }
        public int TopLeftY { get; set; }

        public bool Intersects(Rectangle secondRectangle)
        {
            int x = secondRectangle.TopLeftX;
            int y = secondRectangle.TopLeftY;

            if (IsInRange(x, this.TopLeftX, this.Width) && IsInRange(y, this.TopLeftY, this.Height))
            {
                return true;
            }
            return false;
        }

        private bool IsInRange(int number, int from, int size)
        {
            if (number >= from && number <= from + size)
            {
                return true;
            }
            return false;
        }
    }
}