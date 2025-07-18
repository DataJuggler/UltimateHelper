﻿

#region using statements

using System;
using System.Collections.Generic;
using System.Text;
using DataJuggler.UltimateHelper.Objects;
using System.IO;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class TextHelper
    /// <summary>
    /// This class contains helper methods for dealing with strings.
    /// </summary>
    public class TextHelper
    {
        
        #region Methods

            #region CapitalizeFirstChar(string word, bool lowerCase = false)
            /// <summary>
            /// This method capitalizes the first character of a word.
            /// </summary>
            /// <param name="word">The word to capitalize the first character of.</param>
            /// <param name="lowerCase">(Optional) If true the word is returned lower</param>
            /// <returns></returns>
            public static string CapitalizeFirstChar(string word, bool lowerCase = false)
            {
                // set the newWord
                string newWord = "";

                // If Null String
                if (String.IsNullOrEmpty(word))
                {
                    // Return Null String
                    return newWord;
                }

                // Create Char Array
                Char[] letters = word.ToCharArray();

                // if lower case
                if (lowerCase)
                {
                    // if this word is less than 3
                    if (word.Length < 3)
                    {
                        // go with all lower case here
                        newWord = word.ToLower();

                        // return the newWord
                        return newWord;
                    }
                    else
                    {
                        // Capitalize First Character
                        letters[0] = Char.ToLower(letters[0]);
                    }
                }
                else
                {
                    // Capitalize First Character
                    letters[0] = Char.ToUpper(letters[0]);
                }

                // set the newWord
                newWord = new string(letters);

                // return new string
                return newWord;

            }
            #endregion

            #region CloneLines(List<TextLine> lines)
            /// <summary>
            /// returns a list of Lines
            /// </summary>
            public static List<TextLine> CloneLines(List<TextLine> lines)
            {
                // initial value
                List<TextLine> cloneLines = new List<TextLine>();

                // local
                int lineNumber = 0;

                // If the lines collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // Iterate the collection of TextLine objects
                    foreach (TextLine textLine in lines)
                    {
                        // Increment the value for lineNumber
                        lineNumber++;

                        TextLine cloneLine = new TextLine();
                        cloneLine.Text = textLine.Text;

                        // Set the value
                        cloneLine.LineNumber = lineNumber;

                        // Set the CloneLines
                        cloneLines.Add(cloneLine);
                    }
                }

                // return value
                return cloneLines;
            }
            #endregion

            #region CombineStrings(string string1, string string2)
            /// <summary>
            /// This method appends string2 to the end of string1
            /// </summary>
            public static string CombineStrings(string string1, string string2)
            {
                // initial value
                string combinedString = "";

                // Create a StringBuilder
                StringBuilder sb = new StringBuilder(string1);

                // append string2
                sb.Append(string2);

                // set the return value
                combinedString = sb.ToString();

                // return value
                return combinedString;
            }
            #endregion

            #region CombineStrings(string string1, string string2, string string3)
            /// <summary>
            /// This method appends string3 and string 2 to the end of string1
            /// </summary>
            public static string CombineStrings(string string1, string string2, string string3)
            {
                // initial value
                string combinedString = "";

                // Create a StringBuilder
                StringBuilder sb = new StringBuilder(string1);

                // append string2
                sb.Append(string2);

                // append string3
                sb.Append(string3);

                // set the return value
                combinedString = sb.ToString();

                // return value
                return combinedString;
            }
            #endregion

            #region CombineStrings(string string1, string string2, string string3, string string4)
            /// <summary>
            /// This method appends string2, string3 and string4 to the end of string1
            /// </summary>
            public static string CombineStrings(string string1, string string2, string string3, string string4)
            {
                // initial value
                string combinedString = "";

                // Create a StringBuilder
                StringBuilder sb = new StringBuilder(string1);

                // append string2
                sb.Append(string2);

                // append string3
                sb.Append(string3);

                // append string4
                sb.Append(string4);

                // set the return value
                combinedString = sb.ToString();

                // return value
                return combinedString;
            }
            #endregion

            #region CombineStringsEx(string string1, string string2, string seperator = "")
            /// <summary>
            /// This method appends string2 to the end of string1
            /// </summary>
            public static string CombineStringsEx(string string1, string string2, string seperator = "")
            {
                // initial value
                string combinedString = "";

                // Create a StringBuilder
                StringBuilder sb = new StringBuilder(string1);

                // if the seperator exists
                if (Exists(seperator))
                {
                    // add the seperator
                    sb.Append(seperator);
                }

                // append string2
                sb.Append(string2);

                // set the return value
                combinedString = sb.ToString();

                // return value
                return combinedString;
            }
            #endregion

            #region CombineStringsEx(string string1, string string2, string string3, string seperator = "")
            /// <summary>
            /// This method appends string3 and string 2 to the end of string1
            /// </summary>
            public static string CombineStringsEx(string string1, string string2, string string3, string seperator = "")
            {
                // initial value
                string combinedString = "";

                // Create a StringBuilder
                StringBuilder sb = new StringBuilder(string1);

                // if the seperator exists
                if (Exists(seperator))
                {
                    // add the seperator
                    sb.Append(seperator);
                }

                // append string2
                sb.Append(string2);

                // if the seperator exists
                if (Exists(seperator))
                {
                    // add the seperator
                    sb.Append(seperator);
                }

                // append string3
                sb.Append(string3);

                // set the return value
                combinedString = sb.ToString();

                // return value
                return combinedString;
            }
            #endregion

            #region CombineStringsEx(string string1, string string2, string string3, string string4, string seperator = "")
            /// <summary>
            /// This method appends string2, string3 and string4 to the end of string1
            /// </summary>
            public static string CombineStringsEx(string string1, string string2, string string3, string string4, string seperator = "")
            {
                // initial value
                string combinedString = "";

                // Create a StringBuilder
                StringBuilder sb = new StringBuilder(string1);

                // if the seperator exists
                if (Exists(seperator))
                {
                    // add the seperator
                    sb.Append(seperator);
                }

                // append string2
                sb.Append(string2);

                // if the seperator exists
                if (Exists(seperator))
                {
                    // add the seperator
                    sb.Append(seperator);
                }

                // append string3
                sb.Append(string3);

                // if the seperator exists
                if (Exists(seperator))
                {
                    // add the seperator
                    sb.Append(seperator);
                }

                // append string4
                sb.Append(string4);

                // set the return value
                combinedString = sb.ToString();

                // return value
                return combinedString;
            }
            #endregion

            #region Exists
            
                #region Exists(string string1)
                /// <summary>
                /// This method returns true if string given exists
                /// </summary>
                public static bool Exists(string string1)
                {
                    // initial value
                    bool exists = false;

                    // test if the string exists
                    exists = (!String.IsNullOrEmpty(string1));
                
                    // return value
                    return exists;
                }
                #endregion

                #region Exists(string string1, string string2)
                /// <summary>
                /// This method returns true if BOTH strings given exist
                /// </summary>
                public static bool Exists(string string1, string string2)
                {
                    // initial value
                    bool exists = false;

                    // this method returns true if both strings exist
                    bool string1Exists = Exists(string1);
                    bool string2Exists = Exists(string2);

                    // set the return value
                    exists = ((string1Exists) && (string2Exists));

                    // return value
                    return exists;
                }
                #endregion

                #region Exists(string string1, string string2, string string3)
                /// <summary>
                /// This method returns true if ALL THREE strings given exist
                /// </summary>
                public static bool Exists(string string1, string string2, string string3)
                {
                    // initial value
                    bool exists = false;

                    // this method returns true if all three strings exist
                    bool string1Exists = Exists(string1);
                    bool string2Exists = Exists(string2);
                    bool string3Exists = Exists(string3);

                    // set the return value
                    exists = ((string1Exists) && (string2Exists) && (string3Exists));

                    // return value
                    return exists;
                }
                #endregion

                #region Exists(string string1, string string2, string string3, string string4)
                /// <summary>
                /// This method returns true if ALL FOUR strings given exist
                /// </summary>
                public static bool Exists(string string1, string string2, string string3, string string4)
                {
                    // initial value
                    bool exists = false;

                    // this method returns true if all four strings exist
                    bool string1Exists = Exists(string1);
                    bool string2Exists = Exists(string2);
                    bool string3Exists = Exists(string3);
                    bool string4Exists = Exists(string4);

                    // set the return value
                    exists = ((string1Exists) && (string2Exists) && (string3Exists) && (string4Exists));

                    // return value
                    return exists;
                }
                #endregion

                #region Exists(string string1, string string2, string string3, string string4, string string5)
                /// <summary>
                /// This method returns true if ALL Five strings given exist
                /// </summary>
                public static bool Exists(string string1, string string2, string string3, string string4, string string5)
                {
                    // initial value
                    bool exists = false;

                    // this method returns true if all five strings exist
                    bool string1Exists = Exists(string1);
                    bool string2Exists = Exists(string2);
                    bool string3Exists = Exists(string3);
                    bool string4Exists = Exists(string4);
                    bool string5Exists = Exists(string5);

                    // set the return value
                    exists = ((string1Exists) && (string2Exists) && (string3Exists) && (string4Exists) && (string5Exists));

                    // return value
                    return exists;
                }
                #endregion

            #endregion

            #region ExportTextLines(List<TextLine> lines, string mustContain, string mustNotContain)
            /// <summary>
            /// This method returns the Text Lines, with Environment.NewLine appended after each line.
            /// </summary>
            /// <param name="lines">A collection of TextLines to rebuild into a file or block'</param>
            /// <param name="mustContainText">If present, a line must have this to be added.</param>
            /// <param name="mustNotContainText">If present, a line with will not be added</param>
            public static string ExportTextLines(List<TextLine> lines, string mustContainText = "", string mustNotContainText = "")
            {
                // initial value
                string result = "";

                // locals
                bool mustContain = TextHelper.Exists(mustContainText);
                bool mustNotContain = TextHelper.Exists(mustNotContainText);
                bool addLine = false;

                // If the lines collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // Create a new instance of a 'StringBuilder' object.
                    StringBuilder sb = new StringBuilder();

                    // Iterate the collection of TextLine objects
                    foreach (TextLine line in lines)
                    {
                        // reset, default to true
                        addLine = true;

                        // if the value for mustContain is true
                        if (mustContain)
                        {
                            // add line is true if this string contains the mustContainText
                            addLine = line.Text.Contains(mustContainText);
                        }

                        // if addLine is true,a nd the mustNotContain is true
                        if (addLine && mustNotContain)
                        {
                            // if the line contains the mustNotContainText                            
                            if (line.Text.Contains(mustNotContainText))
                            {
                                // do not add this line
                                addLine = false;
                            }
                        }

                        // if addLine is true
                        if (addLine)
                        {
                            // Add this line
                            sb.Append(line.Text);

                            // Add a NewLine char
                            sb.Append(Environment.NewLine);
                        }
                    }

                    // Set the result
                    result = sb.ToString();
                }
                
                // return value
                return result;
            }
            #endregion

            #region ExportTextLines(List<Word> words)
            /// <summary>
            /// This method returns a string which is made up of the text of all the words plus a space.
            /// The string is then trimmed and returned.
            /// </summary>
            /// <param name="words">A collection of Word objects'</param>            
            public static string ExportWords(List<Word> words)
            {
                // initial value
                string result = "";

                // If the words collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(words))
                {
                    // Create a new instance of a 'StringBuilder' object.
                    StringBuilder sb = new StringBuilder();

                    // Iterate the collection of Word objects
                    foreach (Word word in words)                    
                    {
                        // Add this word
                        sb.Append(word.Text);

                        // Add a space
                        sb.Append(TextHelper.Indent(1));
                    }

                    // set the return value
                    result = sb.ToString().Trim();
                }
                
                // return value
                return result;
            }
            #endregion
            
            #region FindTextInQuotes(string input)
            /// <summary>
            /// method returns the Text In Quotes
            /// </summary>
            public static string FindTextInQuotes(string input)
            {
                // Initial Value
                string innerText = string.Empty;

                // verify the string exists
                if (TextHelper.Exists(input))
                {
                    // Find the start and end index of the quotes
                    int startIndex = input.IndexOf('"');
                    int endIndex = input.LastIndexOf('"');

                    // Check if both startIndex and endIndex are valid
                    if (startIndex >= 0 && endIndex > startIndex)
                    {
                        // Extract the substring between the quotes
                        innerText = input.Substring(startIndex + 1, endIndex - startIndex - 1);
                    }
                }

                // Return Value
                return innerText;
            }
            #endregion
            
            #region FormatPhoneNumber(string rawNumber)
            /// <summary>
            /// Format Phone Number
            /// </summary>
            public static string FormatPhoneNumber(string rawNumber)
            {
                // initial value
                string phoneNumber = "";

                // temp value
                string digitsOnly = NumericHelper.GetNumbersOnly(rawNumber);

                // If the digitsOnly string exists
                if (TextHelper.Exists(digitsOnly))
                {
                    // if the number is like 18005551234
                    if (digitsOnly.StartsWith("1"))
                    {
                        // Trim off the 1
                        digitsOnly = digitsOnly.Substring(1);
                    }

                    // if 10 digits
                    if (digitsOnly.Length == 10)
                    {
                        // Format the number (area code) + xxx - xxxx
                        phoneNumber = "(" + digitsOnly.Substring(0, 3) + ") " + digitsOnly.Substring(3, 3) + " - " + digitsOnly.Substring(6);
                    }
                }

                // return value
                return phoneNumber;
            }
            #endregion
            
            #region GetSpacesCount(string text)
            /// <summary>
            /// This method returns the number of preceding spaces in the text given.
            /// </summary>
            /// <param name=""></param>
            /// <returns></returns>
            public static int GetSpacesCount(string text)
            {
                // initial value
                int spacesCount = 0;

                // local
                int count = 0;

                // if the text exists                
                if (!String.IsNullOrEmpty(text))
                {
                    // Iterate the collection of char objects
                    foreach (char c in text)
                    {
                        // if this is a space
                        if (c.ToString() == " ")
                        {
                            count++;
                        }
                        else
                        {
                            // set the return value
                            spacesCount  = count;

                            // exit this loop
                            break;
                        }
                    }
                }

                // return value
                return spacesCount;
            }
            #endregion

            #region GetTextLines(string sourceText, bool parseWords = false, char[] delimiter = null)
            /// <summary>
            /// This method returns a list of TextLine objects.
            /// </summary>
            /// <param name="sourceText"></param>
            /// <param name="parseWords">If true, the words will be attempted to be parsed for each line.</param>
            /// <param name="delimiter">A character array of the delmiters to parse on.</param>
            /// <returns></returns>
            public static List<TextLine> GetTextLines(string sourceText, bool parseWords = false, char[] delimiter = null)
            {  
                // initial value
                List<TextLine> textLines = null;

                // local
                int index = -1;

                // If the value for the property Exists.sourceText is true
                if (Exists(sourceText))
                {
                    // Create a new collection of 'TextLine' objects.
                    textLines = new List<TextLine>();

                    // if the NewLine is not found
                    if (!sourceText.Contains(Environment.NewLine))
                    {
                        if (sourceText.Contains("\r"))
                        {   
                            // The parsing on lines isn't working, this is a good hack till
                            // I rewrite the parser to be more robust someday
                            sourceText = sourceText.Replace("\r", Environment.NewLine);
                        }
                        else if (sourceText.Contains("\n"))
                        {
                            // The parsing on lines isn't working, this is a good hack till
                            // I rewrite the parser to be more robust someday
                            sourceText = sourceText.Replace("\n", Environment.NewLine);
                        }
                    }

                    // just in case, fix for the hack
                    sourceText = sourceText.Replace("\r\r", "\r").Replace("\n\n", "\n");

                    // typical delimiter characters
                    char[] delimiterChars = Environment.NewLine.ToCharArray();

                    // local
                    int counter = -1;

                    // verify the sourceText exists
                    if (!String.IsNullOrEmpty(sourceText))
                    {
                        // Get the list of strings
                        string[] linesOfText = sourceText.Split(delimiterChars);

                        // now iterate the strings
                        foreach (string lineOfText in linesOfText)
                        {
                            // local
                            string text = lineOfText;

                            // increment the counter
                            counter++;

                            // add every other row
                            if ((counter % 2) == 0)
                            {
                                // Increment the value for index
                                index++;

                                // Create a new TextLine
                                TextLine textLine = new TextLine(text);

                                // Set Index and LineNumber
                                textLine.Index = index;
                                textLine.LineNumber = index + 1;

                                // if parseWords is true and the textLine exists
                                if ((parseWords) && (textLine.HasText))
                                {
                                    // parse the words for this textLine
                                    textLine.Words = TextHelper.GetWords(textLine.Text, delimiter);
                                }

                                // now add this textLine to textLines collection
                                textLines.Add(textLine);
                            }
                        }
                    }
                }

                // return value
                return textLines;
            }
            #endregion

            #region GetTextLines(string sourceText, bool parseWords = false, char[] delimiter = null)
            /// <summary>
            /// This method returns a list of TextLine objects form a file.
            /// </summary>
            /// <param name="filePath">The file to read the text of and parse the lines from.</param>            
            /// <param name="parseWords">If true, the words will be attempted to be parsed for each line.</param>
            /// <param name="delimiter">A character array of the delmiters to parse on.</param>
            /// <returns></returns>
            public static List<TextLine> GetTextLinesFromFile(string filePath, bool parseWords = false, char[] delimiter = null)
            {  
                // initial value
                List<TextLine> textLines = null;

                // If the value for the property Exists.sourceText is true
                if ((TextHelper.Exists(filePath)) && (FileHelper.Exists(filePath)))
                {
                    // get the sourceText
                    string sourceText = File.ReadAllText(filePath);

                    // Call the GetTextLines to handle the rest
                    textLines = GetTextLines(sourceText, parseWords, delimiter);
                }

                // return value
                return textLines;
            }
            #endregion

            #region GetWords(string sourceText, char[] delimiters = null)
            /// <summary>
            /// This method returns all of the words in a list of strings
            /// </summary>
            /// <param name="sourceText"></param>
            /// <returns></returns>
            public static List<Word> GetWords(string sourceText, char[] delimiters = null)
            {
                 // Use stackalloc to create a ReadOnlySpan<char> from char[]
                ReadOnlySpan<char> spanDelimiters = delimiters;

                List<Word> words = GetWords(sourceText, spanDelimiters);

                // return value
                return words;
            }
            #endregion

            #region GetWords(string originalText)
            /// <summary>
            /// This method returns all of the words in a list of strings
            /// </summary>
            /// <param name="sourceText"></param>
            /// <returns></returns>
            public static List<Word> GetWords(ReadOnlySpan<char> inputAsSpan, ReadOnlySpan<char> delimiters = default )
            {
                // Initial value
                List<Word> words = new List<Word>();
    
                // Local
                int index = -1;
    
                // Default delimiter characters
                ReadOnlySpan<char> defaultDelimiterChars = stackalloc char[] { ' ', '-', '/', ',', '.', ':', '\t' };
    
                // Use provided delimiters or default if not provided
                ReadOnlySpan<char> delimiterChars = delimiters.Length > 0 ? delimiters : defaultDelimiterChars;

                // Verify the sourceText exists
                if (!inputAsSpan.IsEmpty)
                {
                    // update 11.15.2024: Switching to SpanSplitEnumerator
                    MemoryExtensions.SpanSplitEnumerator<char> ranges = inputAsSpan.Split(delimiterChars);

                    // iterate the ranges
                    foreach (var segment in inputAsSpan.Split(delimiterChars))
                    {
                        // Get the text
                        ReadOnlySpan<char> text = inputAsSpan[segment];

                        if (!text.IsEmpty)
                        {
                            // Increment the value for index
                            index++;
                
                            // Create a new Word
                            Word word = new Word(text.ToString());
                
                            // Set the index
                            word.Index = index;
                
                            // Add this word to words collection
                            words.Add(word);
                        }
                    }
                }
    
                // Return value
                return words;
            }
            #endregion

            #region GetWordsAsStrings(string sourceText, char[] delimiters = null)
            /// <summary>
            /// This method returns all of the string in a the sourceText.
            /// This is a modified version of GetWords that returns a list of strings.
            /// </summary>
            /// <param name="sourceText"></param>
            /// <returns></returns>
            public static List<string> GetWordsAsStrings(string sourceText, char[] delimiters = null)
            {
                // initial value
                List<string> words = new List<string>();

                // typical delimiter characters
                char[] delimiterChars = { ' ', '-', '/', ',', '.', ':', '\t' };

                // if the delimiters exists
                if (delimiters != null)
                {
                    // use the delimiters passedin
                    delimiterChars = delimiters;
                }

                // verify the sourceText exists
                if (!String.IsNullOrEmpty(sourceText))
                {
                    // Get the list of strings
                    string[] strings = sourceText.Split(delimiterChars);

                    // now iterate the strings
                    foreach (string stringWord in strings)
                    {
                        // verify the word is not an empty string or a space
                        if (!String.IsNullOrEmpty(stringWord))
                        {
                            // now add this word to words collection
                            words.Add(stringWord);
                        }
                    }
                }

                // return value
                return words;
            }
            #endregion

            #region GetWordsFromCapitalLetters(string sourceText)
            /// <summary>
            /// returns a list of Words From Capital Letters
            /// </summary>
            public static List<Word> GetWordsFromCapitalLetters(string sourceText)
            {
                // initial value
                List<Word> words = new List<Word>();

                // local
                Word word = null;

                // If the sourceText string exists
                if (TextHelper.Exists(sourceText))
                {
                    // Iterate the collection of char objects
                    foreach(char c in sourceText)
                    {
                        // if UpperCase
                        if (Char.IsUpper(c))
                        {
                            // Create a new instance of a 'Word' object.
                            word = new Word();

                            // Set the initial vaue
                            word.Text = c.ToString();

                            // Add this word
                            words.Add(word);
                        }
                        else if (word != null)
                        {
                            // Add to the existing word
                            word.Text += c;
                        }
                    }
                }

                // return value
                return words;
            }
            #endregion
            
            #region Indent(int indent)
            /// <summary>
            /// This method is used to indent a string with x number of preceding spaces.
            /// This is used when writing out the Xml for the XmlWriter
            /// </summary>
            /// <param name="indent"></param>
            /// <returns></returns>
            public static string Indent(int indentSpaces)
            {
                // initial value
                string indent = "";

                // Create a new instance of a 'StringBuilder' object.
                StringBuilder sb = new StringBuilder();

                // If the value for indentSpaces is greater than zero
                if (indentSpaces > 0)
                {
                    // iterate up to the number of spaces to indent
                    for (int x = 0; x < indentSpaces; x++)
                    {
                        // Add a space
                        sb.Append(" ");
                    }
                }

                // set the return value
                indent = sb.ToString();

                // return value
                return indent;
            }
            #endregion

            #region IsEqual(string sourceString, string sourceString2, bool textMustExist = true, bool caseMustMatch = false))
            /// <summary>
            /// This method returns true if the two strings given are equal.
            /// </summary>
            /// <param name="sourceString">The source string</param>
            /// <param name="sourceString2">The string to be compared to.</param>
            /// <param name="textMustExist">This defaults to true; if true both strings must exist or false is returned even if the strings match.</param>
            /// <param name="caseMustMatch">This defaults to false; if true the comparison will be a case sensitive comparison.
            /// <returns></returns>
            public static bool IsEqual(string sourceString, string sourceString2, bool textMustExist = true, bool caseMustMatch = false)
            {
                // initial value
                bool isEqual = false;

                // local s
                bool abort = false;
                int compare = 0;

                // if the text must exist
                if (textMustExist)
                {
                    // if both strings do not exist than abort will be set to true
                    abort = (!Exists(sourceString, sourceString2));
                }

                //if we should continue
                if (!abort)
                {
                    // if we need to a Case Sensitive Comparison
                    if (caseMustMatch)
                    {
                        // the case must match
                        compare = String.Compare(sourceString, sourceString2, false);
                    }
                    else
                    {
                        // the case must match
                        compare = String.Compare(sourceString, sourceString2, true);
                    }
                    
                    // set the return value
                    isEqual = (compare == 0);      
                }

                // return value
                return isEqual;
            }
            #endregion

            #region  StartsWithAVowel(string word)
            /// <summary>
            /// Does this string start with a vowel
            /// </summary>
            /// <param name="word"></param>
            /// <returns></returns>
            public static bool StartsWithAVowel(string word)
            {
                // initial value
                bool startsWithAVowel = false;

                // if the word exists
                if (TextHelper.Exists(word))
                {
                    // get the firstCharacter
                    string firstCharacter = word[0].ToString().ToLower();

                    // determine if a vowel
                    switch (firstCharacter)
                    {
                        case "a":
                        case "e":
                        case "i":
                        case "o":
                        case "u":

                            // set to true
                            startsWithAVowel = true;

                            // required
                            break;
                    }
                }

                // return value
                return startsWithAVowel;
            }
            #endregion
            
            #region ReplaceTextInFile(string fileName, string searchText, string replaceValue)
            /// <summary>
            /// Replace Text In File
            /// </summary>
            public static void ReplaceTextInFile(string fileName, string searchText, string replaceValue)
            {
                try
                {
                    // If all 3 strings exist
                    if (TextHelper.Exists(fileName, searchText, replaceValue))
                    {
                        // Create a new collection of 'Replacement' objects.
                        List<Replacement> replacements = new List<Replacement>();

                        // Add to the Replacements
                        replacements.Add(new Replacement(searchText, replaceValue));

                        // Call the override for this method
                        ReplaceTextInFile(fileName, replacements);
                    }
                }
                catch (Exception error)
                {
                    // For debugging only for now
                    DebugHelper.WriteDebugError("ReplaceTextInFile", "TextHelper", error);
                }
            }
            #endregion

            #region ReplaceTextInFile(string fileName, List<Replacement> replacements)
            /// <summary>
            /// Replace Text In File
            /// </summary>
            public static void ReplaceTextInFile(string fileName, List<Replacement> replacements)
            {
                try
                {
                    // If the string exists and the replacements collection has 1 or more item
                    if ((TextHelper.Exists(fileName) && (ListHelper.HasOneOrMoreItems(replacements))))
                    {
                        // Get the textLines
                        List<TextLine> lines = GetTextLinesFromFile(fileName);

                        // If the lines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(lines))
                        {
                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // Iterate the collection of Replacement objects
                                foreach (Replacement replacement in replacements)
                                {  
                                    // This is needed so DataManager can become Data
                                    if (line.Text.Contains(replacement.SearchText))
                                    {
                                        // if the ReplaceValue exists in the SearchText
                                        if (replacement.SearchText.Contains(replacement.ReplaceValue))
                                        {
                                            // Update the text - This check was needed so DataManager can become Data
                                            line.Text = line.Text.Replace(replacement.SearchText, replacement.ReplaceValue);
                                        }
                                        else if (!line.Text.Contains(replacement.ReplaceValue))
                                        {
                                            // Update the text
                                            line.Text = line.Text.Replace(replacement.SearchText, replacement.ReplaceValue);
                                        }
                                    }
                                }
                            }
                        }

                        // Get the new fileText
                        string fileText = ExportTextLines(lines);

                        // Delete the file
                        File.Delete(fileName);

                        // Write the file back out
                        File.WriteAllText(fileName, fileText);
                    }
                }
                catch (Exception error)
                {
                    // For debugging only for now
                    DebugHelper.WriteDebugError("ReplaceTextInFile", "TextHelper", error);
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
