using Logger.Interfaces;
using System.Text;

namespace Logger.Models.Layout
{
    public class XmlLayout : ILayout
    {
        public string GetFormat()
        {
            StringBuilder logFormat = new StringBuilder();

            logFormat.AppendLine("<log>")
                     .AppendLine("   <date>{0}</date>")
                     .AppendLine("   <level>{1}</level>")
                     .AppendLine("   <message>{2}</message>")
                     .AppendLine("</log>");

            return logFormat.ToString().Trim();
        }
    }
}