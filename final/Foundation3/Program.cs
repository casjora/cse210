using System;

class Program
{
    static void Main(string[] args)
    {
        var address = new Address("123 Event St", "New York", "NY", "USA");

        Event lecture = new Lecture("C# Workshop", "Learn the basics of C#", "12/06/2024", "10:00 AM", address, "John Smith", 100);
        Event reception = new Reception("Networking Event", "Meet professionals in the tech industry", "12/07/2024", "6:00 PM", address, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic", "Enjoy a day out in the park", "12/08/2024", "12:00 PM", address, "Sunny");

        var events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("\n----------------------------------\n");
        }
    }
}