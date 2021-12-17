namespace _10_Interfaces_WorkingWithDI.Currency
{
    public interface ICurrency
    {
        string Name { get; }

        decimal Value { get; }
    }
}