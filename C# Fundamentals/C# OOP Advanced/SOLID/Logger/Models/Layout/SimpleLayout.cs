using Logger.Interfaces;

namespace Logger.Models.Layout
{
    public class SimpleLayout : ILayout
    {
        public string GetFormat()
        {
            return "{0} - {1} - {2}";
        }
    }
}