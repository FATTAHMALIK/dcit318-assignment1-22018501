Console.Write("Enter your numerical grade (0-100): ");

if (double.TryParse(Console.ReadLine(), out double grade))
{
    if (grade < 0 || grade > 100)
    {
        Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
    }
    else if (grade >= 90)
    {
        Console.WriteLine("Letter Grade: A");
    }
    else if (grade >= 80)
    {
        Console.WriteLine("Letter Grade: B");
    }
    else if (grade >= 70)
    {
        Console.WriteLine("Letter Grade: C");
    }
    else if (grade >= 60)
    {
        Console.WriteLine("Letter Grade: D");
    }
    else
    {
        Console.WriteLine("Letter Grade: F");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a numerical grade.");
}