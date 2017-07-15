using System.Text;

namespace Car_Salesman
{
    public class Car
    {
        private string weight;

        public Car(string model, Engine engine)
            : this(model, engine, -1, "n/a")
        {
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine, weight, "n/a")
        {
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine, -1, color)
        {
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight.ToString();
            this.Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }

        public string Weight
        {
            get { return this.weight; }
            set
            {
                if (value == "-1")
                {
                    this.weight = "n/a";
                    return;
                }
                this.weight = value;
            }
        }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append($"{this.Model}:");
            info.AppendLine();
            info.Append(this.Engine.ToString());
            info.AppendLine();
            info.Append($"Weight: {this.Weight}");
            info.AppendLine();
            info.Append($"Color: {this.Color}");

            return info.ToString();
        }
    }
}