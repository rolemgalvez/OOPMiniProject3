using System;

namespace HomeworkThirty.ConsoleUILibrary.Extensions
{
    public static class GetInput
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        private static int RequestInt(this string message, bool withMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool validInput = false;
            bool validRange = true;

            while (validInput == false || validRange == false)
            {
                Console.Write(message);
                validInput = int.TryParse(Console.ReadLine(), out output);

                if (withMinMax)
                {
                    validRange = (output >= minValue) && (output <= maxValue);
                }                
            }

            return output;
        }
    }
}
