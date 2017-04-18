namespace WebApiUtilities.Core.Interface
{
    public interface ITextFormatUtilities
    {
        string RemoveLetter(string text);
        string RemoveSpecialSymbols(string text);
        string RemoveNotations(string text);
    }
}
