namespace CalculatorTMS;

internal class Program
{
    static void Main(string[] args)
    {
        double firstNumber;
        double secondNumber;
        string? symbolг;

        do
        {
            Console.WriteLine("Введите первое число:");
        } while (!double.TryParse(Console.ReadLine(), out firstNumber));

        do
        {
            Console.WriteLine("Введите математический символ (+, -, *, /, ^):");
            symbol = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(symbol) || (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/" && symbol != "^"));

        do
        {
            Console.WriteLine("Введите второе число:");
        } while (!double.TryParse(Console.ReadLine(), out secondNumber));


        switch (symbol)
        {
            case "+":
                {
                    var result = firstNumber + secondNumber;
                    Console.WriteLine(result);
                }
                break;

            case "-":
                {
                    var result = firstNumber - secondNumber;
                    Console.WriteLine(result);
                }
                break;
            case "*":
                {
                    var result = firstNumber * secondNumber;
                    Console.WriteLine(result);
                }
                break;
            case "/":
                {
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя! Соберись и давай с самого начала)");
                    }
                    else
                    {
                        var result = firstNumber / secondNumber;
                        Console.WriteLine(result);
                    }
                }
                break;
            case "^":
                {
                    var result = Math.Pow(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                break;
        }
    }
}