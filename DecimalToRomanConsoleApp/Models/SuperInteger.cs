namespace DecimalToRomanConsoleApp.Models
{
    public class SuperInteger
    {
        #region Snippet_SuperMethods

        /// <summary>Converts an integer to roman number</summary>
        /// <param name="number">Number</param>
        /// <returns>String</returns>
        public static string ConvertToRoman(int number)
        {
            string  []m = { "", "M", "MM", "MMM" };
            string []c = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string []x = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string []i = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string thousands = m[number/1000];
            string hundereds = c[(number%1000)/100];
            string tens = x[(number%100)/10];
            string ones = i[number%10];

            return thousands + hundereds + tens + ones;
        }

        #endregion
    }
}