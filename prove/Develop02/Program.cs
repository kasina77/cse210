using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }

    var entries = new List<Entry>();

    while (entries.Count() <= 10) {
        var entry = new Entry("1/26/2023");
        entries.Add(entry);
    }

    for (var i = 0; i < 10; i++) {
        var entry = new Entry('1/26/2023');
        entries.Add(entry);
    }   
    var prompts = new List<String> {'Who was the most interesting person I interacted with today?', 'What was the best part of my day?', 'How did I see the hand of the Lord in my life today?', 'What was the strongest emotion I felt today?', 'If I had one thing I could do over today, what would it be?'};
    var rdm = new Random();
    var randomIndex = rdm.Next(prompts.Count());
    var randomPrompt = prompts[randomIndex];
    
}