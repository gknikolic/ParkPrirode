using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2
{
    public static class StringExtensions
    {
        public static String PostaviPrvoVelikoSlovo(this String s)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            char[] charArray = s.ToCharArray();

            charArray[0] = Char.ToUpper(charArray[0]);

            for (int i = 1; i < charArray.Length; i++)
                charArray[i] = Char.ToLower(charArray[i]);


            String str;
            str = new String(charArray);

            return str;
        }
    }
}
