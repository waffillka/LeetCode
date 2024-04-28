using System.Text;

namespace Algorithms;

/*
 Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

   Symbol       Value
   I             1
   V             5
   X             10
   L             50
   C             100
   D             500
   M             1000
   For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

   Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

   I can be placed before V (5) and X (10) to make 4 and 9.
   X can be placed before L (50) and C (100) to make 40 and 90.
   C can be placed before D (500) and M (1000) to make 400 and 900.
   Given an integer, convert it to a roman numeral.



   Example 1:

   Input: num = 3
   Output: "III"
   Explanation: 3 is represented as 3 ones.
   Example 2:

   Input: num = 58
   Output: "LVIII"
   Explanation: L = 50, V = 5, III = 3.
   Example 3:

   Input: num = 1994
   Output: "MCMXCIV"
   Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.


   Constraints:

   1 <= num <= 3999
 */
public static class IntegerToRoman
{
    public static string IntToRoman(int num)
    {
        var romanNumerals = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        var roman = new StringBuilder("");
        ;
        foreach (var item in romanNumerals)
        {
            while (num >= item.Key)
            {
                roman.Append(item.Value);
                num -= item.Key;
            }
        }

        return roman.ToString();
    }

    public static string IntToRoman_v2(int num)
    {
        string numS = num.ToString("D4");

        char thousands = numS[0];
        char hundreds = numS[1];
        char tens = numS[2];
        char digits = numS[3];

        int thousandsN = (int)thousands - '0';
        int hundredsN = (int)hundreds - '0';
        int tensN = (int)tens - '0';
        int digitsN = (int)digits - '0';

        StringBuilder sb = new();

        if (thousandsN != 0)
        {
            sb.Append('M', thousandsN);
        }

        if (hundredsN != 0)
        {
            switch (hundreds)
            {
                case '1':
                case '2':
                case '3':
                    sb.Append('C', hundredsN);
                    break;
                case '4':
                    sb.Append("CD");
                    break;
                case '5':
                    sb.Append('D');
                    break;
                case '6':
                case '7':
                case '8':
                    sb.Append('D');
                    sb.Append('C', hundredsN - 5);
                    break;
                case '9':
                    sb.Append("CM");
                    break;
            }
        }

        if (tensN != 0)
        {
            switch (tens)
            {
                case '1':
                case '2':
                case '3':
                    sb.Append('X', tensN);
                    break;
                case '4':
                    sb.Append("XL");
                    break;
                case '5':
                    sb.Append('L');
                    break;
                case '6':
                case '7':
                case '8':
                    sb.Append('L');
                    sb.Append('X', tensN - 5);
                    break;
                case '9':
                    sb.Append("XC");
                    break;
            }
        }

        if (digitsN != 0)
        {
            switch (digits)
            {
                case '1':
                case '2':
                case '3':
                    sb.Append('I', digitsN);
                    break;
                case '4':
                    sb.Append("IV");
                    break;
                case '5':
                    sb.Append('V');
                    break;
                case '6':
                case '7':
                case '8':
                    sb.Append('V');
                    sb.Append('I', digitsN - 5);
                    break;
                case '9':
                    sb.Append("IX");
                    break;
            }
        }

        return sb.ToString();
    }

    private static readonly string[] thousands = ["", "M", "MM", "MMM"];
    private static readonly string[] hundreds = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
    private static readonly string[] tens = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
    private static readonly string[] ones = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"];

    public static string IntToRoman_v3(int num)
    {
        return thousands[num / 1000] + hundreds[num % 1000 / 100] + tens[num % 100 / 10] + ones[num % 10];
    }
}