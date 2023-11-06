namespace Quote.Contracts
{
    public interface IMarginProvider
    {
        decimal GetMargin(string code);
    }
}
