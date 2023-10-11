namespace CalculatorTMS;

internal class Program
{
    static void Main(string[] args)
    {
        var firstNumber = Calculator.ReadFirstNumber();
        var symbol = Calculator.ReadSymbol();
        var secondNumber = Calculator.ReadSecondNumber();
        var result = Calculator.Calculate(firstNumber, symbol, secondNumber);

        Console.WriteLine(result);
    }
}