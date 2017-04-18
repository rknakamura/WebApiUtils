using System;
using System.Globalization;
using System.Text;
using WebApiUtilities.Core.Interface;
using System.Text.RegularExpressions;
using System.Linq;

namespace WebApiUtilities.Core
{
    public class TextFormatUtilities : ITextFormatUtilities
    {

        private const string onlyNumber = "[^0-9]";
        private const string onlyLetter = "[^0-9a-zA-Záéíóúàèìòùâêîôûãõç]";

        public string RemoveLetter(string text)
        {
            var regex = new Regex(onlyNumber);
            return regex.Replace(text, string.Empty);
        }

        public string RemoveNotations(string text)
        {
            var textNormalized = text.Normalize(NormalizationForm.FormD)
                .Where(x => CharUnicodeInfo.GetUnicodeCategory(x) != UnicodeCategory.NonSpacingMark);

            return string.Join(string.Empty, textNormalized);
        }

        public string RemoveSpecialSymbols(string text)
        {
            return new Regex(onlyLetter).Replace(text, string.Empty);
        }
    }
}
