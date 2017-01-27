using System;

public class Substring
{

    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump + 1;

                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                }

                string matchedString = text.Substring(i, Math.Min(endIndex, text.Length - i));
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}