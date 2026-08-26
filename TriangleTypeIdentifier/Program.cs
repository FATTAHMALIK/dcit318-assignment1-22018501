Console.Write("Enter the first side: ");
if (!double.TryParse(Console.ReadLine(), out double side1))
{
    Console.WriteLine("Invalid input.");
    return;
}

Console.Write("Enter the second side: ");
if (!double.TryParse(Console.ReadLine(), out double side2))
{
    Console.WriteLine("Invalid input.");
    return;
}

Console.Write("Enter the third side: ");
if (!double.TryParse(Console.ReadLine(), out double side3))
{
    Console.WriteLine("Invalid input.");
    return;
}

if (side1 <= 0 || side2 <= 0 || side3 <= 0)
{
    Console.WriteLine("Triangle sides must be greater than zero.");
}
else if (side1 + side2 <= side3 ||
         side1 + side3 <= side2 ||
         side2 + side3 <= side1)
{
    Console.WriteLine("The sides do not form a valid triangle.");
}
else if (side1 == side2 && side2 == side3)
{
    Console.WriteLine("Triangle Type: Equilateral");
}
else if (side1 == side2 || side1 == side3 || side2 == side3)
{
    Console.WriteLine("Triangle Type: Isosceles");
}
else
{
    Console.WriteLine("Triangle Type: Scalene");
}