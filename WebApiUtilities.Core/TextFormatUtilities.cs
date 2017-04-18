using System;
using System.Globalization;
using System.Text;
using WebApiUtilities.Core.Interface;
using System.Text.RegularExpressions;

namespace WebApiUtilities.Core
{
    public class TextFormatUtilities : ITextFormatUtilities
    {

        private const string onlyNumber = "[^0-9]";

        public string RemoveLetter(string text)
        {
            var regex = new Regex(onlyNumber);
            return regex.Replace(text, string.Empty);
        }

        public string RemoveNotations(string text)
        {
            string s = text.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }

        public string RemoveSpecialSymbols(string text)
        {
            throw new NotImplementedException();
        }
    }
}
