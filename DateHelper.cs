﻿

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class DateHelper
    /// <summary>
    /// This class has methods to help parse dates safely.
    /// </summary>
    public class DateHelper
    {
        
        #region Methods
    
            #region GetFileNameWithTimestamp(string filename)
            /// <summary>
            /// This method Get File Name With Timestamp
            /// </summary>
            public static string GetFileNameWithTimestamp(string filename)
            {
                // initial value
                string fileNameWithTimeStamp = "";

                // If the filename string exists
                if (TextHelper.Exists(filename))
                {
                    // Get the timestamp
                    string timestamp = GetTimestamp(DateTime.Now);

                    // Create a fileInfo object
                    FileInfo fileInfo = new FileInfo(filename);

                    // Get the name of the file
                    string fileNameWithoutExtension = fileInfo.Name.Substring(0, fileInfo.Name.LastIndexOf("."));

                    // set the return value
                    fileNameWithTimeStamp = fileNameWithoutExtension + " - " + timestamp + fileInfo.Extension;

                    // Add the folder back
                    fileNameWithTimeStamp = Path.Combine(fileInfo.DirectoryName, fileNameWithTimeStamp);
                }
                
                // return value
                return fileNameWithTimeStamp;
            }
        #endregion

            #region GetMinutesThisMillennium()
            /// <summary>
            /// This method returns the number of minutes since January 1, 2000
            /// </summary>
            /// <returns></returns>
            public static int GetMinutesThisMillennium()
            {
                // initial value
                int minutes = 0;

                // create a date for New Year's Day 2000
                DateTime y2k = new DateTime(2000, 1, 1);

                // set the return value
                minutes = (int) DateTime.Now.Subtract(y2k).TotalMinutes;

                // return value
                return minutes;
            }
            #endregion

            #region GetMinutesThisMillennium(DateTime time)
            /// <summary>
            /// This method returns the number of minutes since January 1, 2000
            /// </summary>
            /// <returns></returns>
            public static int GetMinutesThisMillennium(DateTime time)
            {
                // initial value
                int minutes = 0;

                // create a date for New Year's Day 2000
                DateTime y2k = new DateTime(2000, 1, 1);

                // set the return value
                minutes = (int) time.Subtract(DateTime.Now).TotalMinutes;

                // return value
                return minutes;
            }
            #endregion

            #region GetMonthEnd(int year = 0, int month = 0)
            /// <summary>
            /// This method returns date at the end of the month.
            /// <param name="year">The year used to return the start date and end date</param>
            /// <param name="month">The month to return the start date and end date</param>
            /// </summary>
            public static DateTime GetMonthEnd(int year = 0, int month = 0)
            {
                // initial value
                DateTime monthEnd;

                // locals
                int day = 0;
                int hour = 23;
                int min = 59;
                int sec = 59;

                // update the params for Year and Month if not supplied
                if (year == 0)
                {
                    // Set the value for year
                    year = DateTime.Now.Year;
                }

                // Set the value for month
                if (month == 0)
                {
                    // Set the value for month
                    month = DateTime.Now.Month;
                }

                // set the value for day
                day = DateTime.DaysInMonth(year, month);

                // now create the monthEnd date
                monthEnd = new DateTime(year, month, day, hour, min, sec);

                // return value
                return monthEnd;
            }
            #endregion
            
            #region GetMonthName(DateTime date)
            /// <summary>
            /// This method returns the Month Name
            /// </summary>
            public static string GetMonthName(DateTime date, bool abbreviate = false)
            {
                // initial value
                string monthName = "";

                // Get the month
                int month = date.Month;

                switch (month)
                {
                    case 1:

                        // Get the month name
                        monthName = "January";

                        // required
                        break;

                    case 2:

                        // Get the month name
                        monthName = "February";

                        // required
                        break;

                    case 3:

                        // Get the month name
                        monthName = "March";

                        // required
                        break;

                    case 4:

                        // Get the month name
                        monthName = "April";

                        // required
                        break;

                    case 5:

                        // Get the month name
                        monthName = "May";

                        // required
                        break;

                    case 6:

                        // Get the month name
                        monthName = "June";

                        // required
                        break;

                    case 7:

                        // Get the month name
                        monthName = "July";

                        // required
                        break;

                    case 8:

                        // Get the month name
                        monthName = "August";

                        // required
                        break;

                    case 9:

                        // Get the month name
                        monthName = "September";

                        // required
                        break;

                    case 10:

                        // Get the month name
                        monthName = "October";

                        // required
                        break;

                    case 11:

                        // Get the month name
                        monthName = "November";

                        // required
                        break;

                    case 12:

                        // Get the month name
                        monthName = "December";

                        // required
                        break;
                }

                // if abbreviate is true
                if ((abbreviate) && (TextHelper.Exists(monthName)))
                {
                    // Get the first 3 characters
                    monthName = TextHelper.CapitalizeFirstChar(monthName.Substring(0, 3).ToLower());
                }

                
                // return value
                return monthName;
            }
            #endregion
            
            #region GetMonthStart(int year = 0, int month = 0)
            /// <summary>
            /// This method returns the Month Start
            /// </summary>
            public static DateTime GetMonthStart(int year = 0, int month = 0)
            {
                // initial value
                DateTime monthStart;

                // locals
                int day = 1;
                int hour = 0;
                int min = 0;
                int sec = 0;

                // update the params for Year and Month if not supplied
                if (year == 0)
                {
                    // Set the value for year
                    year = DateTime.Now.Year;
                }

                // Set the value for month
                if (month == 0)
                {
                    // Set the value for month
                    month = DateTime.Now.Month;
                }

                // now create the monthStart date
                monthStart = new DateTime(year, month, day, hour, min, sec);

                // return value
                return monthStart;
            }
            #endregion

            #region GetShortDateText(DateTime date, bool abbreviateMonthName = true, bool addComma = true)
            /// <summary>
            /// This method returns the date as [Month Abbreviation] [Day] [Year], ideal for file names
            /// </summary>
            public static string GetShortDateText(DateTime date, bool abbreviateMonthName = true, bool addComma = true)
            {
                // initial value
                string text = "";

                // Get the month
                string month = GetMonthName(date, abbreviateMonthName);
                
                if (addComma)
                {
                    // Create the text such as August 5, 2021 or Aug 5, 2021
                    text = month + " " + date.Day + ", " + date.Year;
                }
                else
                {
                    // Create the text such as August 5 2021 or Aug 5 2021
                    text = month + " " + date.Day + " " + date.Year;
                }

                // return value
                return text;
            }
            #endregion
            
            #region GetShortDateTime(DateTime date)
            /// <summary>
            /// This method returns the Time and Date of the string given.
            /// </summary>
            public static string GetShortDateTime(DateTime date)
            {
                // initial value
                string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

                // return value
                return time;
            }
            #endregion

            #region GetTimestamp(DateTime date)
            /// <summary>
            /// This method returns the date plus the time
            /// </summary>
            public static string GetTimestamp(DateTime date)
            {
                // initial value
                string timestamp = "";

                // Get the month
                string month = GetTwoDigitMonth(date);
                string hour = GetTwoDigitHour(date);
                string day = GetTwoDigitDay(date);
                string minute = GetTwoDigitMinute(date);

                // Create a string builder
                StringBuilder sb = new StringBuilder();

                // Add each section of the timestamp
                sb.Append(month);
                sb.Append(day);
                sb.Append(date.Year);
                sb.Append(hour);
                sb.Append(minute);

                // Setup the Timestamp
                timestamp = sb.ToString();
                
                // return value
                return timestamp;
            }
            #endregion

            #region GetTwoDigitDay(DateTime date)
            /// <summary>
            /// This method returns a two digit day for the date given.
            /// </summary>
            /// <param name="date"></param>
            /// <returns></returns>
            public static string GetTwoDigitDay(DateTime date)
            {
                // initial value
                string twoDigitDay = "";

                // set the twoDigitDay
                twoDigitDay = date.Day.ToString();

                // if the Length is less than two
                if (twoDigitDay.Length < 2)
                {
                    // prepend a zero to the Day
                    twoDigitDay = "0" + date.Day.ToString();
                }

                // return value
                return twoDigitDay;
            }
            #endregion

            #region GetTwoDigitHour(DateTime date)
            /// <summary>
            /// This method returns a two digit hour for the date given.
            /// </summary>
            /// <param name="date"></param>
            /// <returns></returns>
            public static string GetTwoDigitHour(DateTime date)
            {
                // initial value
                string twoDigitHour = "";

                // set the twoDigitHour
                twoDigitHour = date.Hour.ToString();

                // if the Length is less than two
                if (twoDigitHour.Length < 2)
                {
                    // prepend a zero to the Hour
                    twoDigitHour = "0" + date.Hour.ToString();
                }

                // return value
                return twoDigitHour;
            }
            #endregion

            #region GetTwoDigitMinute(DateTime date)
            /// <summary>
            /// This method returns a two digit minute for the date given.
            /// </summary>
            /// <param name="date"></param>
            /// <returns></returns>
            public static string GetTwoDigitMinute(DateTime date)
            {
                // initial value
                string twoDigitMinute = "";

                // set the twoDigitMinute
                twoDigitMinute = date.Minute.ToString();

                // if the Length is less than two
                if (twoDigitMinute.Length < 2)
                {
                    // prepend a zero to the Minute
                    twoDigitMinute = "0" + date.Minute.ToString();
                }

                // return value
                return twoDigitMinute;
            }
            #endregion
   
            #region GetTwoDigitMonth(DateTime date)
            /// <summary>
            /// This method returns the month for the date given.
            /// </summary>
            /// <param name="date"></param>
            /// <returns></returns>
            public static string GetTwoDigitMonth(DateTime date)
            {
                // initial value
                string twoDigitMonth = "";

                // set the twoDigitMonth
                twoDigitMonth = date.Month.ToString();

                // if the Length is less than two
                if (twoDigitMonth.Length < 2)
                {
                    // prepend a zero to the month
                    twoDigitMonth = "0" + date.Month.ToString();
                }

                // return value
                return twoDigitMonth;
            }
            #endregion
            
            #region IsAfter(DateTime sourceDate, DateTime targetDate, bool includeTime = true)
            /// <summary>
            /// This method returns true if the targetDate comes AFTER the sourceDate.
            /// </summary>
            public static bool IsAfter(DateTime sourceDate, DateTime targetDate, bool includeTime = true)
            {
                // initial value
                bool isAfter = false;

                // if time should be Not be included in the comparison
                if (!includeTime)
                {
                    // recreate the sourceDate without the time
                    sourceDate = new DateTime(sourceDate.Year, sourceDate.Month, sourceDate.Day);

                    // recreate the targetDate without the time
                    targetDate = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day);
                }

                // compare just the dates
                isAfter = (targetDate > sourceDate);

                // return value
                return isAfter;
            }
            #endregion

            #region IsBefore(DateTime sourceDate, DateTime targetDate, bool includeTime = true)
            /// <summary>
            /// This method returns true if the targetDate comes Before the sourceDate.
            /// </summary>
            public static bool IsBefore(DateTime sourceDate, DateTime targetDate, bool includeTime = true)
            {
                // initial value
                bool isAfter = false;

                // if time should be Not be included in the comparison
                if (!includeTime)
                {
                    // recreate the sourceDate without the time
                    sourceDate = new DateTime(sourceDate.Year, sourceDate.Month, sourceDate.Day);

                    // recreate the targetDate without the time
                    targetDate = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day);
                }

                // compare the dates
                isAfter = (targetDate < sourceDate);

                // return value
                return isAfter;
            }
            #endregion

            #region IsDate(string date)
            /// <summary>
            /// This method returns true if the string can be parsed into a date.
            /// </summary>
            /// <param name="date"></param>
            /// <returns></returns>
            public static bool IsDate(string date)
            {
                // initial value
                bool isDate = false;

                // If the date string exists
                if (TextHelper.Exists(date))
                {
                    try
                    {
                        // local
                        DateTime actualDate = new DateTime(1900, 1, 1);

                        // try and parse the date
                        isDate = DateTime.TryParse(date, out actualDate);

                        // if the value for isDate is true
                        if (isDate)
                        {
                            // if the date did not parse to a valid range
                            if ((actualDate.Year < 1900) || (actualDate.Year > DateTime.Now.Year))
                            {
                                // not a valid date
                                isDate = false;
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        // for debugging only
                        string err = error.ToString();
                    }
                }

                // return value
                return isDate;
            }
            #endregion

            #region IsDateInRange(DateTime sourceDate, int allowedDays)
            /// <summary>
            /// This method returns true if the sourceDate is not any older than the allowedDays
            /// </summary>
            public static bool IsDateInRange(DateTime sourceDate, int allowedDays)
            {
                // initial value
                bool isDateInRange = false;

                try
                {
                    // subtract the number of days
                    TimeSpan ts = DateTime.Now.Subtract(sourceDate);

                    // set the return value
                    isDateInRange = (ts.TotalDays <= allowedDays);
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();
                }

                // return value
                return isDateInRange;
            }
            #endregion

            #region IsSameDay(DateTime sourceDate, DateTime targetDate)
            /// <summary>
            /// This method returns true if the targetDate is the same date as the sourceDate.
            /// With this override Time is automatically removed so Time is NOT A FACTOR.
            /// </summary>
            public static bool IsSameDay(DateTime sourceDate, DateTime targetDate)
            {
                // initial value
                bool isSameDay = false;

                // remove time values in case they are included
                sourceDate = new DateTime(sourceDate.Year, sourceDate.Month, sourceDate.Day);
                targetDate = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day);

                // set the return value
                isSameDay = (sourceDate == targetDate);

                // return value
                return isSameDay;
            }
            #endregion

            #region ParseDate(string sourceString, DateTime defaultValue, DateTime errorValue)
            /// <summary>
            /// This method is used to safely parse a string
            /// </summary>
            public static DateTime ParseDate(string sourceString, DateTime defaultValue, DateTime errorValue)
            {
                // initial value
                DateTime returnValue = defaultValue;

                try
                {
                    // if the sourceString exists
                    if (!String.IsNullOrEmpty(sourceString))
                    {
                        // perform the parse
                        returnValue = Convert.ToDateTime(sourceString);
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set the value to the errorValue
                    returnValue = errorValue;
                }

                // return value
                return returnValue;
            }
            #endregion

            #region ParseEightDigitDate(string dateText)
            /// <summary>
            /// returns the Date from a format yyyymmdd.
            /// </summary>
            public static DateTime ParseEightDigitDate(string dateText)
            {
                // initial value
                DateTime date = new DateTime(1900, 1, 1);

                // locals
                string yearText = "";
                string monthText = "";
                string dayText = "";
                int year = 0;
                int month = 0;
                int day = 0;

                // If the dateText string exists
                if ((TextHelper.Exists(dateText)) && (dateText.Length == 8))
                {
                    // set the yearText
                    yearText = dateText.Substring(0, 4);

                    // set the monthText
                    monthText = dateText.Substring(4, 2);

                    // if the month starts with a 0
                    if (monthText.StartsWith("0"))
                    {
                        // trim off the first 0
                        monthText = monthText.Substring(1);
                    }

                    // set the dayText
                    dayText = dateText.Substring(6, 2);

                    // if the day starts with a 0
                    if (dayText.StartsWith("0"))
                    {
                        // trim off the first 0
                        dayText = dayText.Substring(1);
                    }

                    // set the year
                    year = NumericHelper.ParseInteger(yearText, 0, -1);
                    month = NumericHelper.ParseInteger(monthText, 0, -1);
                    day = NumericHelper.ParseInteger(dayText, 0, -1);

                    if ((year > 0) && (month > 0) && (day > 0))
                    {
                        // Set the date
                        date = new DateTime(year, month, day);
                    }
                }
    
                // return value
                return date;
            }
            #endregion
            
        #endregion
            
    }
    #endregion

}
