Console.WriteLine("Hello, World!");
Console.WriteLine("Enter first number");
Double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("write second number");
Double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The sum of the two numbers is: " + (firstNumber + secondNumber));
if (firstNumber > secondNumber)
{
    Console.WriteLine("The first number is greater than the second number.");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("The first number is less than the second number.");
}
else
{
    Console.WriteLine("The first number is equal to the second number.");
}
if(secondNumber > firstNumber)
{
    Console.WriteLine("The second number is greater than the first number.");
}
else if(secondNumber < firstNumber)
{
    Console.WriteLine("The second number is less than the first number.");
}
else
{
    Console.WriteLine("The second number is equal to the first number.");
}

