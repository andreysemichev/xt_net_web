using System.Text.RegularExpressions;

namespace task_3._3._2
{
    public static class StringExtension
    {
        public enum StringType
        {
            None,
            Russian,
            English,
            Number,
            Mixed
        }

        public static StringType GetStringType(this string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                if (IsEnglish(inputString))
                {
                    return StringType.English;
                }

                else if (IsRussian(inputString))
                {
                    return StringType.Russian;
                }

                else if (IsDigit(inputString))
                {
                    return StringType.Number;
                }

                else if (IsMixed(inputString))
                {
                    return StringType.Mixed;
                }

                else
                {
                    return StringType.None;
                }
            }

            else
            {
                return StringType.None;
            }
        }

        private static bool IsEnglish(string inputString)
        {
            return Regex.IsMatch(inputString.ToLower(), @"\b([a-z])+\b");
        }

        private static bool IsRussian(string inputString)
        {
            return Regex.IsMatch(inputString.ToLower(), @"\b([а-яё])+\b");
        }

        private static bool IsMixed(string inputString)
        {
            return Regex.IsMatch(inputString.ToLower(), @"([a-zA-Z]|[а-яА-Я]|[0-9])+\w");
        }

        private static bool IsDigit(string inputString)
        {
            return Regex.IsMatch(inputString.ToLower(), @"\b[\d]+\b");
        }
    }
}
