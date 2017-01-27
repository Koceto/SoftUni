using System;

public class InstructionSet_broken
{
    public static void Main()
    {
        string command = Console.ReadLine().ToLower();
        string[] myArray = command.Split(' ');
        //For judge.softuni.bg var result need to be inside the loop(while)
        long result = long.Parse(myArray[1]);

        while (myArray[0] != "end")
        {
            switch (myArray[0])
            {
                case "inc":
                    {
                        result++;
                        break;
                    }
                case "dec":
                    {
                        result--;
                        break;
                    }
                case "add":
                    {
                        result += long.Parse(myArray[myArray.Length - 1]);
                        break;
                    }
                case "mla":
                    {
                        result *= long.Parse(myArray[myArray.Length - 1]);
                        break;
                    }
            }
            //For judge.softuni.bg the console.writeLine should be after the myArray = command.split();
            Console.WriteLine(result);

            command = Console.ReadLine().ToLower();
            myArray = command.Split(' ');
        }
    }
}