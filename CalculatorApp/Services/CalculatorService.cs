namespace CalculatorApp.Services;

public class CalculatorService
{
    private const int MaxDigits = 8;

    public string CurrentValue { get; private set; } = "0";

    public void AppendDigit(int digit)
    {
        if (digit > 9 || digit < 0)
        {
            throw new ArgumentOutOfRangeException(
                paramName: nameof(digit),
                message: "Digit must be between 0 and 9.");
        }

        if (CurrentValue.Length >= MaxDigits)
        {
            return; // Ignore if max digits reached
        }

        if (CurrentValue == "0" && digit == 0)
        {
            return; // Ignore leading zeros
        }

        CurrentValue = CurrentValue == "0" ?
            digit.ToString() :
            CurrentValue + digit.ToString();
    }
}
