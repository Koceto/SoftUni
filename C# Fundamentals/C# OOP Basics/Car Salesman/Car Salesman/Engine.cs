using System.Text;

namespace Car_Salesman
{
    public class Engine
    {
        private string displacement;

        public Engine(string model, int power)
            : this(model, power, -1, "n/a")
        {
        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
            this.Displacement = displacement.ToString();
        }

        public string Model { get; set; }
        public int Power { get; set; }

        public string Displacement
        {
            get { return this.displacement; }

            set
            {
                if (value == "-1")
                {
                    this.displacement = "n/a";
                    return;
                }

                this.displacement = value;
            }
        }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append($"{this.Model}:");
            info.AppendLine();
            info.Append($"Power: {this.Power}");
            info.AppendLine();
            info.Append($"Displacement: {this.Displacement}");
            info.AppendLine();
            info.Append($"Efficiency: {this.Efficiency}");

            return info.ToString();
        }
    }
}