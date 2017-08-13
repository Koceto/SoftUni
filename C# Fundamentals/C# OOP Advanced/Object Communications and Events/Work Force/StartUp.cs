using System;
using System.Collections.Generic;
using System.Linq;
using Work_Force.Entities;
using Work_Force.Interfaces;

namespace Work_Force
{
    public delegate void OnWeekPassEventHandler();

    public class StartUp
    {
        private static List<Job> jobs = new List<Job>();
        private static List<IEmploee> emploees = new List<IEmploee>();
        public static OnWeekPassEventHandler WeekPass;

        public static void Main()
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandArgs[0])
                {
                    case "Job":
                        Job job = new Job(commandArgs[1], int.Parse(commandArgs[2]), emploees.FirstOrDefault(e => e.Name == commandArgs[3]));

                        job.JobComplete += JobCompleted;
                        WeekPass += job.Update;

                        jobs.Add(job);
                        break;

                    case "StandartEmployee":
                        emploees.Add(new StandartEmployee(commandArgs[1]));
                        break;

                    case "PartTimeEmployee":
                        emploees.Add(new PartTimeEmployee(commandArgs[1]));
                        break;

                    case "Pass":
                        Pass();
                        break;

                    case "Status":
                        jobs.ForEach(j => Console.WriteLine($"Job: {j.Name} Hours Remaining: {j.WorkRequired}"));
                        break;
                }
            }
        }

        private static void Pass()
        {
            if (WeekPass != null)
            {
                WeekPass();
            }
        }

        public static void JobCompleted(Job job)
        {
            Console.WriteLine($"Job {job.Name} done!");
            jobs.Remove(job);
            WeekPass -= job.Update;
        }
    }
}