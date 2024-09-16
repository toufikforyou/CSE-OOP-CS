public class Example
{
    // const: Compile-time constant
    public const int ConstValue = 100;

    // readonly: Runtime constant, set either at declaration or in the constructor
    public readonly int ReadonlyValue;

    public Example(int value)
    {
        ReadonlyValue = value; // Can be set in the constructor
    }

    public void DisplayValues()
    {
        Console.WriteLine($"ConstValue: {ConstValue}");
        Console.WriteLine($"ReadonlyValue: {ReadonlyValue}");
    }
}