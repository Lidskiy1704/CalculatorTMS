namespace CalculatorTMS;

internal class Calculator
{
    public static double ReadFirstNumber()
    {
        double firstNumber;

        do
        {
            Console.WriteLine("Введите первое число:");
        } while (!double.TryParse(Console.ReadLine(), out firstNumber));

        return firstNumber;
    }

    public static double ReadSecondNumber()
    {
        double secondNumber;

        do
        {
            Console.WriteLine("Введите второе число:");
        } while (!double.TryParse(Console.ReadLine(), out secondNumber));

        return secondNumber;
    }

    public static string ReadSymbol()
    {
        string symbol;

        do
        {
            Console.WriteLine("Введите математический символ (+, -, *, /, ^):");
            symbol = Console.ReadLine();
        } while (!IsMathSymbol(symbol));

        return symbol;
    }

    public static double? Calculate(double firstNumber, string symbol, double secondNumber)
    {
        switch (symbol)
        {
            case "+":
                {
                    return firstNumber + secondNumber;
                }

            case "-":
                {
                    return firstNumber - secondNumber;
                }

            case "*":
                {
                    return firstNumber * secondNumber;
                }

            case "/":
                {
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя! Соберись и давай с самого начала)");
                        return null;
                    }

                    return firstNumber / secondNumber;
                }

            case "^":
                {
                    return Math.Pow(firstNumber, secondNumber);
                }

            default:
                return null;
        }
    }

    private static bool IsMathSymbol(string symbol)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            return false;
        }

        return symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/" || symbol == "^";
    }
}
