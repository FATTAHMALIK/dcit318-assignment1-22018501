Console.Write("Enter your age: ");

if (int.TryParse(Console.ReadLine(), out int age))
{
    if (age < 0)
    {
        Console.WriteLine("Invalid age.");
    }
    else if (age <= 12 || age >= 65)
    {
        Console.WriteLine("Ticket Price: GHC7");
    }
    else
    {
        Console.WriteLine("Ticket Price: GHC10");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid age.");
}