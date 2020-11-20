using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetSplitNumber
{
    public class Words
    {
        public Words(string alphaNumeric)
        {
            AlphaNumeric = alphaNumeric;
        }
        protected string AlphaNumeric { get; }
        public string GetLastNumberOnString()
        {
            string numberString = "";
            if (!string.IsNullOrWhiteSpace(AlphaNumeric))
            {
                var arrayString = AlphaNumeric.ToArray();
                int position = 0;
                List<int> collectionNumber = new List<int>();
                for (int i = 0; i < arrayString.Length; i++)
                {
                    position += 1;
                    int number;
                    var character = arrayString[i].ToString();
                    if (int.TryParse(character, out number))
                    {
                        collectionNumber.Add(number);
                    }
                    else
                    {
                        if (collectionNumber.Count > 0)
                        {
                            collectionNumber.RemoveAt(0);
                        }
                    }
                }
                collectionNumber.ForEach(x => numberString += x.ToString());
            }
            return numberString;
        }

        public string GetNumberOnCurrency()
        {
            string pattern = @"[^,.0-9]";
            string substitution = @"";
            RegexOptions options = RegexOptions.Multiline;
            Regex regex = new Regex(pattern, options);
            string result = regex.Replace(AlphaNumeric, substitution);
            return result;
        }
    }
}
