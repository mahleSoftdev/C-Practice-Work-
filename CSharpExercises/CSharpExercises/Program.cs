using CSharpExercises;

// Each entry: exercise number -> (title, method to run)
var exercises = new SortedDictionary<int, (string Title, Action Run)>
{
    { 1, ("Print Hello and Name", Exercise01.Run) },
    { 2, ("Sum of Two Numbers",   Exercise02.Run) },
    { 3, ("Divide Two Numbers", Exercise03.Run) },
    { 4, ("Mathematical Operations", Exercise04.Run) },
    { 5, ("Swap Two Numbers", Exercise05.Run) },
    { 6, ("Multiply Three Numbers", Exercise06.Run) }
};

while (true)
{
    Console.Clear();
    Console.WriteLine("=== C# Exercises ===\n");

    foreach (var (number, exercise) in exercises)
    {
        Console.WriteLine($"{number,3}. {exercise.Title}");
    }
    Console.WriteLine("  0. Exit\n");

    Console.Write("Choose an exercise: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int choice))
    {
        Console.WriteLine("\nPlease enter a number. Press any key to try again...");
        Console.ReadKey(true);
        continue;
    }

    if (choice == 0)
    {
        break;
    }

    if (!exercises.TryGetValue(choice, out var selected))
    {
        Console.WriteLine($"\nThere is no exercise {choice}. Press any key to try again...");
        Console.ReadKey(true);
        continue;
    }

    Console.Clear();
    Console.WriteLine($"--- Exercise {choice}: {selected.Title} ---\n");

    try
    {
        selected.Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nSomething went wrong: {ex.Message}");
    }

    Console.WriteLine("\n\nPress any key to return to the menu...");
    Console.ReadKey(true);
}