namespace Raw_Data
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Wieght = weight;
            this.Type = type;
        }

        public int Wieght { get; set; }

        public string Type { get; set; }
    }
}