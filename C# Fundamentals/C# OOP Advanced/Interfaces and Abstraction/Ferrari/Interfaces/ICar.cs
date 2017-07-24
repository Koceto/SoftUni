public interface ICar
{
    string Model { get; }
    string Driver { get; }

    string Accelerate();

    string Brake();
}