using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryPersonalCode
{

    public class PersonalCode
    {
        /// <summary>
        /// Расчет контрольной цифры СНИЛС
        /// </summary>
        /// <param name="textString">СНИЛС</param>
        /// <returns>
        /// возвращает true, если СНИЛС задан верно, false – в случае неверного СНИЛС
        /// </returns>
        public bool CheckPersonakCode(string textString)
        {
            textString = textString.Replace("-", "");
            textString = textString.Replace(" ", "");
            if (string.IsNullOrWhiteSpace(textString))
            {
                return false;
            }
            if (!Regex.Match(textString, "[0-9]").Success)
            {
                return false;
            }
            for (int i = 0; i < textString.Length; i++)
            {
                if (i !=11)
                {
                    return false;
                }
            }

           

            string sobNumb = textString.Remove(8, 2);
            string kontrolNumb = textString.Remove(0, 8);
            int summ=0;

            char[] chars = sobNumb.ToCharArray();
            Array.Reverse(chars);

            for (int i =1; i <= chars.Length; i++)
            {
                summ += Convert.ToInt32(char.GetNumericValue(chars[i])) * i;
            }
            int kontrolNumb2 = Convert.ToInt32(kontrolNumb);

            if (summ < 100)
                kontrolNumb2 = summ;
            if (summ == 100 || summ == 101)
                kontrolNumb2 = 00;
            if (summ > 101)
            {
                kontrolNumb2 =summ%101;
                return true;
            }

            return true;
        }
    }
}
