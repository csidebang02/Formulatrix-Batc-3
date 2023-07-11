public class NegativePriceException : Exception
{
    public NegativePriceException() : base("Harga service tidak boleh negatif.")
    {
    }
}
