namespace ICT3101_Calculator;

public class Calculator
{
    public Calculator()
    {
    }

    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }

        return result;
    }

    public double Add(double num1, double num2)
    {
        return (num1 + num2);
    }

    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }

    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public double Divide(double num1, double num2)
    {
        //return double.PositiveInfinity;
        if (num1 == 0 && num2 == 0) return 1;
        if (num1 == 0) return 0;
        if (num2 == 0) return Double.PositiveInfinity;
        if (num1 == 0 || num2 == 0) throw new ArgumentException("Number cannot be zero");

        return (num1 / num2);
    }

    public double Factorial(double num1)
    {
        if (num1 < 0) throw new ArgumentException("Number cannot be negative");

        var result = 1;
        for (var i = 1; i <= num1; i++)
        {
            result *= i;
        }

        return result;
    }

    public double AreaTriangle(double num1, double num2)
    {
        return num1 * num2 * 0.5;
    }

    public double AreaCircle(double num)
    {
        return Math.Round(Math.PI * (num * num), 3);
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0 || (num1 < num2)) throw new ArgumentException("Invalid argument");
        return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0 || (num1 < num2)) throw new ArgumentException("Invalid argument");
        return Divide(Factorial(num1), Multiply(Factorial(Subtract(num1, num2)), Factorial(num2)));
        ;
    }

    public double CalculateCurrentFailureIntensity(float initial, float avg, float total)
    {
        return Multiply(initial, Subtract(1, Divide(avg, total)));
    }

    public double CalculateAverageExpectedFailure(float initial, float total, float time)
    {
        return Math.Round(Multiply(total, Subtract(1, Math.Exp(Multiply(-Divide(initial, total), time)))));
    }
    
    public double CalculateLogCurrentFailureIntensity(double decayParam, double initialFailure, double expectedFailure)
    {
        return Math.Round(Multiply(initialFailure, Math.Exp(Multiply(-decayParam, expectedFailure))),2);
    }
    
    public double CalculateLogAverageExpectedFailure(double decayParam, double initialFailure, double cpuHours)
    {
        return Math.Round(Multiply(Divide(1, decayParam), Math.Log(Add(Multiply(Multiply(initialFailure, decayParam), cpuHours), 1))));
    }
    
    public double CalucateDefectDensity(double defects, double size)
    {
        return Divide(defects, size);
    }

    public double CalcuateKssi(double initial, double newTotal, double changed)
    {
        return Subtract(Add(initial, newTotal), changed);
    }
}