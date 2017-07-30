namespace RoliTheCoder
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Event
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public HashSet<string> Participants { get; set; }

        public int ParticipantsCount()
        {
            return Participants.Count();
        }
    }

    public class RoliEvents
    {
        public static void Main()
        {
            var allEvents = new List<Event>();
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "time")
            {
                var id = int.Parse(input[0]);
                var nameArr = input[1].ToCharArray();
                var name = string.Join("", nameArr.Skip(1));
                var eventSym = nameArr[0];
                var participants = input.Skip(2).ToArray();

                if (eventSym != '#')
                {
                    input = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                var currEvent = new Event
                {
                    ID = int.Parse(input[0]),
                    Name = name,
                    Participants = new HashSet<string>()
                };

                foreach (var participant in participants)
                {
                    var partSym = participant[0];

                    if (partSym == '@')
                    {
                        currEvent
                            .Participants
                            .Add(participant);
                    }

                    if (allEvents.Any(x => x.Name == name && x.ID == id))
                    {
                        allEvents
                            .First(x => x.ID == id && x.Name == name)
                            .Participants
                            .Add(participant);
                    }
                }

                if (!allEvents.Any(x => x.ID == currEvent.ID) && !allEvents.Any(x => x.Name == name))
                {
                    allEvents.Add(currEvent);
                }

                input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var eventInfo in allEvents.OrderByDescending(x => x.ParticipantsCount()).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{eventInfo.Name} - {eventInfo.ParticipantsCount()}");

                foreach (var participant in eventInfo.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
