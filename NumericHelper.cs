

#region using statements

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class NumericHelper
    /// <summary>
    /// This class contains helper classes for dealing with numbers.
    /// </summary>
    public class NumericHelper
    {
        
        #region Methods

            #region Between(int value, int minValue, int maxValue) + 1 overload

                #region Between(int value, int minValue, int maxValue)
                /// <summary>
                /// This method returns true if the value passed in is between min and max
                /// </summary>
                /// <param name="value">The value to test against the min and max values.</param>
                /// <param name="minValue">The minimum allowed value.</param>
                /// <param name="maxValue">The maximum allowed value.</param>
                /// <returns></returns>
                public static bool Between(int value, int minValue, int maxValue)
                {
                    // initial value
                    bool between = ((value >= minValue) && (value <= maxValue));

                    // return value
                    return between;
                }
                #endregion

                #region Between(double value, double minValue, double maxValue)
                /// <summary>
                /// This method returns true if the value passed in is between min and max
                /// </summary>
                /// <param name="value">The value to test against the min and max values.</param>
                /// <param name="minValue">The minimum allowed value.</param>
                /// <param name="maxValue">The maximum allowed value.</param>
                public static bool Between(double value, double minValue, double maxValue)
                {
                    // initial value
                    bool between = ((value >= minValue) && (value <= maxValue));

                    // return value
                    return between;
                }
                #endregion

            #endregion

            #region DivideDoublesAsDecimals(double dividend, double devisor, int digits)
            /// <summary>
            /// returns the Doubles As Decimals. The purose of this method is C# does not handle division by doubles properly.
            /// </summary>
            public static double DivideDoublesAsDecimals(double dividend, double divisor, int digits)
            {
                // initial value
                double returnValue = 0;

                if ((dividend != 0) && (divisor != 0))
                {
                    // cast as doubles
                    decimal dividend2 = (decimal) dividend;
                    decimal devisor2 = (decimal) divisor;

                    // get the quotient
                    decimal quotient = dividend2 / devisor2;

                    // get the quotient
                    quotient = Math.Round(quotient, digits);

                    // Set the return value
                    returnValue = (double) quotient;
                }
                
                // return value
                return returnValue;
            }
            #endregion
            
            #region EnsureInRange(int value, int minValue, int MaxValue)
            /// <summary>
            /// This method returns the In Range
            /// </summary>
            public static int EnsureInRange(int value, int minValue, int maxValue)
            {
                // if too low
                if (value < minValue)
                {
                    // set to minValue
                    value = minValue;
                }
                else if (value > maxValue)
                {
                    // set to maxValue
                    value = maxValue;
                }

                // return value
                return value;
            }
            #endregion

            #region EnsureInRange(double value, double minValue, double MaxValue)
            /// <summary>
            /// This method returns the In Range
            /// </summary>
            public static double EnsureInRange(double value, double minValue, double maxValue)
            {
                // if too low
                if (value < minValue)
                {
                    // set to minValue
                    value = minValue;
                }
                else if (value > maxValue)
                {
                    // set to maxValue
                    value = maxValue;
                }

                // return value
                return value;
            }
            #endregion

            #region EnsureInRange(Decimal value, Decimal minValue, Decimal MaxValue)
            /// <summary>
            /// This method returns the In Range
            /// </summary>
            public static Decimal EnsureInRange(Decimal value, Decimal minValue, Decimal maxValue)
            {
                // if too low
                if (value < minValue)
                {
                    // set to minValue
                    value = minValue;
                }
                else if (value > maxValue)
                {
                    // set to maxValue
                    value = maxValue;
                }

                // return value
                return value;
            }
            #endregion

            #region EnsureInRange(List<int> values, int minValue, int maxValue)
            /// <summary>
            /// This method creates a new list, and ensure the members are In Range from the source values
            /// </summary>
            public static List<int> EnsureInRange(List<int> values, int minValue, int maxValue)
            {
                // initial value
                List<int> newList = null;

                // If the values collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(values))
                {
                    // create a new list
                    newList = new List<int>();

                    // iterate the list
                    foreach (int value in values)
                    {
                        // Add this value
                        newList.Add(EnsureInRange(value, minValue, maxValue));
                    }
                }

                // return value
                return newList;
            }
            #endregion

            #region EnsureInRange(List<double> values, double minValue, double maxValue)
            /// <summary>
            /// This method creates a new list, and ensure the members are In Range from the source values
            /// </summary>
            public static List<double> EnsureInRange(List<double> values, double minValue, double maxValue)
            {
                // initial value
                List<double> newList = null;

                // If the values collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(values))
                {
                    // create a new list
                    newList = new List<double>();

                    // iterate the list
                    foreach (double value in values)
                    {
                        // Add this value
                        newList.Add(EnsureInRange(value, minValue, maxValue));
                    }
                }

                // return value
                return newList;
            }
            #endregion

            #region EnsureInRange(List<Decimal> values, Decimal minValue, Decimal maxValue)
            /// <summary>
            /// This method creates a new list, and ensure the members are In Range from the source values
            /// </summary>
            public static List<Decimal> EnsureInRange(List<Decimal> values, Decimal minValue, Decimal maxValue)
            {
                // initial value
                List<Decimal> newList = null;

                // If the values collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(values))
                {
                    // create a new list
                    newList = new List<Decimal>();

                    // iterate the list
                    foreach (Decimal value in values)
                    {
                        // Add this value
                        newList.Add(EnsureInRange(value, minValue, maxValue));
                    }
                }

                // return value
                return newList;
            }
            #endregion
            
            #region GetNumbersOnly(string source)
            /// <summary>
            /// returns the Numbers Only
            /// </summary>
            public static string GetNumbersOnly(string source)
            {
                // initial value
                string numbersOnly = "";

                if (TextHelper.Exists(source))
                {
                    StringBuilder sb = new StringBuilder();

                    // get the digits only - 0 - 9
                    foreach (Char c in source)
                    {
                        // if a digit
                        if (Char.IsDigit(c))
                        {
                            sb.Append(c);
                        }
                    }

                    // set the return value for numbers only
                    numbersOnly = sb.ToString();
                }
                
                // return value
                return numbersOnly;
            }
            #endregion
            
            #region GetNumericValueOfWord(string word)
            /// <summary>
            /// This method returns the numeric value of the word given.
            /// </summary>
            public static int GetNumericValueOfWord(string word)
            {
                // initial value
                int wordValue = 0;

                // if the string exists
                if (!String.IsNullOrEmpty(word))
                {
                    // iterate each char
                    for (int x = 0; x < word.Length; x++)
                    {
                        // get the current char
                        char c = word[x];

                        // add this value
                        wordValue += Convert.ToInt32(c);
                    }
                }

                // return value
                return wordValue;
            }
            #endregion

            #region GetPrimeNumberAfter(int startAfter)
            /// <summary>
            /// This method returns the Prime Number After the seed given.
            /// </summary>
            public static int GetPrimeNumberAfter(int startAfter)
            {
                // initial value
                int primeNumber = 0;

                // local
                bool isPrime = false;
                int numberToCheck = startAfter;

                do
                {
                    // increment
                    numberToCheck++;

                    // is this a prime number
                    isPrime = IsNumberPrime(numberToCheck);

                    // if the number is prime
                    if (isPrime)
                    {
                        // set the return value
                        primeNumber = numberToCheck;

                        // break out of loop
                        break;
                    }

                } while (isPrime == false);

                // return value
                return primeNumber;
            }
            #endregion

            #region IsInRange(int number, int min, int max)
            /// <summary>
            /// This method is used to check a number is greater than or equal to the min
            /// and less than or equal to the max.
            /// </summary>
            /// <param name="number"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static bool IsInRange(int number, int min, int max)
            {
                // set the return value
                bool isInRange = ((number >= min) && (number <= max));

                // return value
                return isInRange;
            }
            #endregion

            #region IsInRange(double number, double min, double max)
            /// <summary>
            /// This method is used to check a number is greater than or equal to the min
            /// and less than or equal to the max.
            /// </summary>
            /// <param name="number"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static bool IsInRange(double number, double min, double max)
            {
                // set the return value
                bool isInRange = ((number >= min) && (number <= max));

                // return value
                return isInRange;
            }
            #endregion

            #region IsInRange(Decimal number, Decimal min, Decimal max)
            /// <summary>
            /// This method is used to check a number is greater than or equal to the min
            /// and less than or equal to the max.
            /// </summary>
            /// <param name="number"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static bool IsInRange(Decimal number, Decimal min, Decimal max)
            {
                // set the return value
                bool isInRange = ((number >= min) && (number <= max));

                // return value
                return isInRange;
            }
            #endregion

            #region IsInRange(List<int> numbers, int min, int max)
            /// <summary>
            /// This method is used to check if a List of numbers is greater than or equal to the min
            /// and less than or equal to the max.
            /// </summary>
            /// <param name="number"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static bool IsInRange(List<int> numbers, int min, int max)
            {
                // set the return value
                bool isInRange = false;
                
                // If the numbers collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(numbers))
                {
                    // set to true now
                    isInRange = true;

                    // Iterate the collection of int objects
                    foreach (int number in numbers)
                    {
                        // if NOT in range
                        if (!IsInRange(number, min, max))
                        {
                            // set to false
                            isInRange = false;

                            // break out of loop
                            break;
                        }
                    }
                }

                // return value
                return isInRange;
            }
            #endregion

            #region IsInRange(List<double> numbers, double min, double max)
            /// <summary>
            /// This method is used to check if a List of numbers is greater than or equal to the min
            /// and less than or equal to the max.
            /// </summary>
            /// <param name="number"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static bool IsInRange(List<double> numbers, double min, double max)
            {
                // set the return value
                bool isInRange = false;
                
                // If the numbers collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(numbers))
                {
                    // set to true now
                    isInRange = true;

                    // Iterate the collection of double objects
                    foreach (double number in numbers)
                    {
                        // if NOT in range
                        if (!IsInRange(number, min, max))
                        {
                            // set to false
                            isInRange = false;

                            // break out of loop
                            break;
                        }
                    }
                }

                // return value
                return isInRange;
            }
            #endregion

            #region IsInRange(List<Decimal> numbers, Decimal min, Decimal max)
            /// <summary>
            /// This method is used to check if a List of numbers is greater than or equal to the min
            /// and less than or equal to the max.
            /// </summary>
            /// <param name="number"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static bool IsInRange(List<Decimal> numbers, Decimal min, Decimal max)
            {
                // set the return value
                bool isInRange = false;
                
                // If the numbers collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(numbers))
                {
                    // set to true now
                    isInRange = true;

                    // Iterate the collection of Decimal objects
                    foreach (Decimal number in numbers)
                    {
                        // if NOT in range
                        if (!IsInRange(number, min, max))
                        {
                            // set to false
                            isInRange = false;

                            // break out of loop
                            break;
                        }
                    }
                }

                // return value
                return isInRange;
            }
            #endregion

            #region IsNumberPrime(int number)
            /// <summary>
            /// This method returns true if the Number is Prime
            /// </summary>
            public static bool IsNumberPrime(int number)
            {
                // initial value
                bool isPrime = false;

                // check if this is an even number
                bool isEven = ((number % 2) == 0);

                // if an even number
                if (isEven)
                {
                    // if the number is 2
                    if (number == 2)
                    {
                        // 2 is the only even prime number
                        isPrime = true;
                    }
                }
                else
                {
                    // default to true
                    isPrime = true;

                    // get the limit
                    int limit = (int)Math.Sqrt(number);

                    // iterate up to the limit starting at 3
                    for (int i = 3; i <= limit; i += 2)
                    {
                        // if the number divides by another number
                        if ((number % i) == 0)
                        {
                            // notPrime
                            isPrime = false;

                            // break out of the loop
                            break;
                        }
                    }
                }

                // return value
                return isPrime;
            }
            #endregion

            #region IsNumeric(string source, bool removeCommas = true, bool removeDash = true, double defaultValue = -2000000, double errorValue = -2000001)
            /// <summary>
            /// Can this text be parsed to a number
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
            public static bool IsNumeric(string source, bool removeCommas = true, bool removeDash = true, double defaultValue = -2000000, double errorValue = -2000001)
            {
                // initial value
                bool isNumeric = false;

                // local
                string text = source;

                // If the source string exists
                if (TextHelper.Exists(text))
                {
                    // if the value for removeCommas is true
                    if (removeCommas)
                    {
                        // remove any commas
                        text = source.Replace(",", "");
                    }

                    // if removeDash is true
                    if (removeDash)
                    {
                        // get the text
                        text = text.Replace("-", "");
                    }

                    // Get the value
                    int value = ParseInteger(text, (int) defaultValue, (int) errorValue);

                    // set the return value
                    isNumeric = (value > defaultValue);

                    // if not true
                    if (!isNumeric)
                    {   
                        // attempt to parse 2
                        double value2 = ParseDouble(text, defaultValue, errorValue);

                        // set the return value
                        isNumeric = (value2 > defaultValue);
                    }
                }
                

                // return value
                return isNumeric;
            }
            #endregion

            #region ParseDecimal(string sourceString, Decimal defaultValue, Decimal errorValue)
            /// <summary>
            /// This method is used to safely parse a string into a double
            /// </summary>
            public static Decimal ParseDecimal(string sourceString, Decimal defaultValue, Decimal errorValue)
            {
                // initial value
                decimal returnDecimal = defaultValue;

                try
                {
                    // if the sourceString exists
                    if (!String.IsNullOrEmpty(sourceString))
                    {
                        // remove the dollar sign
                        sourceString = sourceString.Replace("$", "");

                        // perform the parse
                        returnDecimal = Convert.ToDecimal(sourceString);
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set the value to the errorValue
                    returnDecimal = errorValue;
                }

                // return value
                return returnDecimal;
            }
            #endregion

            #region ParseDouble(string sourceString, double defaultValue, double errorValue)
            /// <summary>
            /// This method is used to safely parse a string into a double
            /// </summary>
            public static double ParseDouble(string sourceString, double defaultValue, double errorValue)
            {
                // initial value
                double returnDouble = defaultValue;

                try
                {
                    // if the sourceString exists
                    if (!String.IsNullOrEmpty(sourceString))
                    {
                        // remove the dollar sign
                        sourceString = sourceString.Replace("$", "");

                        // perform the parse
                        returnDouble = Convert.ToDouble(sourceString);
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set the value to the errorValue
                    returnDouble = errorValue;
                }

                // return value
                return returnDouble;
            }
            #endregion

            #region ParseInteger(string sourceString, int defaultValue, int errorValue)
            /// <summary>
            /// This method is used to safely parse a string into an integer.
            /// </summary>
            public static int ParseInteger(string sourceString, int defaultValue, int errorValue)
            {
                // initial value
                int returnInt = defaultValue;

                try
                {
                    // if the sourceString exists
                    if (!String.IsNullOrEmpty(sourceString))
                    {
                        // remove the dollar sign
                        sourceString = sourceString.Replace("$", "");

                        // perform the parse
                        returnInt = Convert.ToInt32(sourceString);
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set the value to the errorValue
                    returnInt = errorValue;
                }

                // return value
                return returnInt;
            }
            #endregion

            #region ReturnDecimalRemainderAsDouble(double sourceDouble, double defaultValue, double errorValue)
            /// <summary>
            /// This method returns the Decimal Remainder As a Double
            /// Example 23.45 would return .45
            /// </summary>
            public static double ReturnDecimalRemainderAsDouble(double sourceDouble, double defaultValue, double errorValue)
            {
                // initial value
                double remainder = defaultValue;

                try
                {
                    // set the string 
                    string sourceDoubleString = sourceDouble.ToString();

                    // if the sourceDoubleString
                    if (TextHelper.Exists(sourceDoubleString))
                    {
                        // set the index of the decimalPoint
                        int index = sourceDoubleString.IndexOf(".");

                        // if the index is set
                        if (index >= 0)
                        {
                            // set the temp
                            string sourceString = sourceDoubleString.Substring(index);

                            // if the string exists
                            if (TextHelper.Exists(sourceString))
                            {
                                // set the return value
                                remainder = Double.Parse(sourceString);
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set remainder to the error value
                    remainder = errorValue;
                }

                // return value
                return remainder;
            }
            #endregion

            #region ReturnDecimalRemainderAsInteger(double sourceDouble, int defaultValue, int errorValue)
            /// <summary>
            /// This method returns the Decimal Remainder cast as an integer
            /// </summary>
            public static int ReturnDecimalRemainderAsInteger(double sourceDouble, int defaultValue, int errorValue)
            {
                // initial value
                int remainder = defaultValue;

                try
                {
                    // set the string 
                    string sourceDoubleString = sourceDouble.ToString();

                    // if the sourceDoubleString
                    if (TextHelper.Exists(sourceDoubleString))
                    {
                        // set the index of the decimalPoint
                        int index = sourceDoubleString.IndexOf(".");

                        // if the index is set
                        if (index >= 0)
                        {
                            // set the temp
                            string sourceString = sourceDoubleString.Substring(index);

                            // if the string exists
                            if (TextHelper.Exists(sourceString))
                            {
                                // trim the string and remove the decimal point if present
                                sourceString = sourceString.Replace(".", "").Trim();

                                // set the return value
                                remainder = NumericHelper.ParseInteger(sourceString, defaultValue, errorValue);
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set remainder to the error value
                    remainder = errorValue;
                }

                // return value
                return remainder;
            }
            #endregion
            
            #region RoundDown(double number, int digits)
            /// <summary>
            /// method returns the Down
            /// </summary>
            public static double RoundDown(double number, int digits)
            {
                double factor = Math.Pow(10, digits);
                return Math.Floor(number * factor) / factor;
            }
            #endregion
            
            #region RoundDown(decimal number, int digits)
            /// <summary>
            /// method returns the Down
            /// </summary>
            public static decimal RoundDown(decimal number, int digits)
            {
                decimal factor = (decimal) Math.Pow(10, digits);
                return Math.Floor(number * factor) / factor;
            }
            #endregion
            
            #region RoundUp(decimal number)
            /// <summary>
            /// method RoundsUp to the digits requested
            /// </summary>
            public static decimal RoundUp(decimal number, int digits)
            {
                decimal factor = (decimal) Math.Pow(10, digits);
                return Math.Ceiling(number * factor) / factor;
            }
            #endregion

            #region RoundUp(decimal number)
            /// <summary>
            /// method RoundsUp to the digits requested
            /// </summary>
            public static double RoundUp(double number, int digits)
            {
                double factor = Math.Pow(10, digits);
                return Math.Ceiling(number * factor) / factor;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
