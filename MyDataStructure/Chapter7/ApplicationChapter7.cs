using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter7
{
    public static class ApplicationChapter7
    {
        public static string ReverseWords(string value)
        {
            var tempStrings = value.Split(new char[]{' '});
            value = string.Empty;
            for (int i = 0; i < tempStrings.Length; i++)
            {
                tempStrings[i] = (tempStrings[i] + tempStrings[i][0]).Remove(0,1) + "ay";
            }
            value = String.Join(" ", tempStrings);

            return value;
        }

        public static int WordNums(string stringMy,string word)
        {
            int count = 0;
            for (int i = 0; i < stringMy.Length-(word.Length-1); i++)
            {
                if (stringMy.Substring(i,word.Length)==word)
                {
                    count++;
                }
            }
            return count;
        }

        public static int WordNums(StringBuilder stringBuilder, string word)
        {
            int count = 0;
            string stringMy = stringBuilder.ToString();
            for (int i = 0; i < stringMy.Length - (word.Length - 1); i++)
            {
                if (stringMy.Substring(i, word.Length) == word)
                {
                    count++;
                }
            }
            return count;
        }

        public static string ConvertDoubleDigitToString(int doubleDigit)
        {
            int unit = doubleDigit % 10;
            int ten = doubleDigit / 10;
            string[] splitStrings = new string[2];
            string[] units = new string[] {"one","two","three","four","five","six","seven","eight","nine" };
            string[] tens = new string[] {"twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety" };

            for (int i = 2; i < 10; i++)
            {
                if (i==ten)
                {
                    splitStrings[0] = tens[i - 2];
                    break;
                }
            }

            if (unit==0)
            {
                splitStrings = new string[] {splitStrings[0]};
            }
            else
            {
                for (int i = 1; i < 10; i++)
                {

                    if (i == unit)
                    {
                        splitStrings[1] = units[i - 1];
                    }
                }
            }


            return String.Join("-", splitStrings);

            //switch (ten)
            //{
            //    case 2:
            //        splitStrings[0] = "twenty";
            //        break;
            //    case 3:
            //        splitStrings[0] = "thirty";
            //        break;
            //    case 4:
            //        splitStrings[0] = "forty";
            //        break;
            //    case 5:
            //        splitStrings[0] = "fifty";
            //        break;
            //    case 6:
            //        splitStrings[0] = "sixty";
            //        break;
            //    case 7:
            //        splitStrings[0] = "seventy";
            //        break;
            //    case 8:
            //        splitStrings[0] = "eighty";
            //        break;
            //    case 9:
            //        splitStrings[0] = "ninety";
            //        break;
            //    default:
            //        break;
            //}

            //switch (unit)
            //{
            //    case 1:
            //        splitStrings[0] = "one";
            //        break;
            //    case 2:
            //        splitStrings[0] = "two";
            //        break;
            //    case 3:
            //        splitStrings[0] = "three";
            //        break;
            //    case 4:
            //        splitStrings[0] = "four";
            //        break;
            //    case 5:
            //        splitStrings[0] = "five";
            //        break;
            //    case 6:
            //        splitStrings[0] = "six";
            //        break;
            //    case 7:
            //        splitStrings[0] = "seven";
            //        break;
            //    case 8:
            //        splitStrings[0] = "eight";
            //        break;
            //    case 9:
            //        splitStrings[0] = "nine";
            //        break;
            //    default:
            //        break;
            //}
            //return null;
        }

        public static string[] SplitSampleSentence(string sentence)
        {
            return sentence.Split(new Char[] {' '}, 3);
        }

        public static string[] SplitSampleSentence(StringBuilder sentence)
        {
            return sentence.ToString().Split(new Char[] { ' ' }, 3);
        }

    }
}
