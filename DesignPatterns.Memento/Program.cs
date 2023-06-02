using DesignPatterns.Memento.Models;

#region NotePad Memento

Memory memory = new();

NotePad notePad = new();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Please enter some text: ");
    var userInput = Console.ReadLine();
    notePad.Content = userInput;

    var memento = notePad.Save();

    // last one is current, no need add to memory
    if (i != 4)
    {
        memory.Add(memento);
    }

    Console.WriteLine("\n");
}

if (!memory.NotePadMementos.Any())
{
    Console.WriteLine("You have no momento!");
    return;
}

Console.WriteLine("Do you want to check previous content? [Y / N]");

var userDecision = Console.ReadLine()?.ToLower();

if (userDecision is "y")
{
    Console.WriteLine("You can press the B button to go back.");

    int count = memory.NotePadMementos.Count;

    while (count > 0)
    {
        var userBackwardInput = Console.ReadLine()?.ToLower();
        if (userBackwardInput is "b")
        {
            var currentMomento = memory.GetCurrentMemento();

            if (currentMomento is null)
            {
                Console.WriteLine("That was last memento!");
                return;
            }

            notePad.GoBack(currentMomento);
            var currentText = notePad.GetCurrentContent();
            Console.WriteLine($"Your current text is: {currentText}");
            count--;
        }
        else
            return;
    }
}

else if (userDecision is "n")
{
    Console.WriteLine("Your texts: ");
    var currentMemory = memory.GetCurrentMemory();
    currentMemory.ForEach(memory => Console.WriteLine(memory.ContentMemento));
}

else
{
    return;
}

#endregion

Console.ReadKey();