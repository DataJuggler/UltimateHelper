

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataJuggler.UltimateHelper.Enumerations;
using DataJuggler.UltimateHelper.Objects;

#endregion

namespace DataJuggler.UltimateHelper;


#region class CodeHelper
/// <summary>
/// This class is used to format Code. C# Code for now.
/// </summary>
public class CodeHelper
{
    
    #region Methods

        /// <summary>
        /// This method is used to FormatCode
        /// </summary>
        /// <param name="codeText"></param>
        /// <param name="language"></param>
        /// <param name="indent"></param>
        /// <returns></returns>
        public static string FormatCode(string codeText, LanguageEnum language, int indent = 1)
        {
            // initial value
            string formattedCode = "";

            // locals
            bool blockCommentOn = false;
            string spaces = "";
            bool increaseIndentNextLine = true;
            bool decreaseIndentThisLine = true;

            // Create a StringBuilder
            StringBuilder sb = new StringBuilder();

            // If the codeText string exists
            if (TextHelper.Exists(codeText))
            {
                // Get the textLines
                List<TextLine> lines = TextHelper.GetTextLines(codeText);

                // If the lines collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // if C#, only one done for now
                    if (language == LanguageEnum.CSharp)
                    {
                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in lines)
                        {
                            // Set the value for blockCommentOn is true if hte line starts with /*
                            blockCommentOn = (line.Text.TrimStart().StartsWith(CodeLine.CSharpBlockCommentStart));

                            // if blockComment is currentlyOn
                            if (blockCommentOn)
                            {
                                // if the line starts with blockCommentEnd */
                                if (line.Text.TrimStart().StartsWith(CodeLine.CSharpBlockCommentEnd))
                                {
                                    // set to false
                                    blockCommentOn = false;
                                }
                            }

                            // for debugging only
                            string temp = line.Text;

                            // Create a codeLine
                            CodeLine codeLine = new CodeLine(line, language, blockCommentOn);

                            // if there is text in this line
                            if (codeLine.HasActiveText)
                            {
                                // Next line should increase indent
                                increaseIndentNextLine = (codeLine.ActiveText.TrimStart().StartsWith("{"));
                                decreaseIndentThisLine = (codeLine.ActiveText.TrimStart().StartsWith("}"));                                    
                            }
                            else
                            {
                                increaseIndentNextLine = false;
                                decreaseIndentThisLine = false;
                            }

                            // if this line should decrease
                            if (decreaseIndentThisLine)
                            {
                                // decrease before writing text
                                indent--;
                            }

                            // Set the indent
                            codeLine.Indent = indent;

                            // Add this line
                            spaces = TextHelper.Indent(codeLine.Indent * 4);
                            sb.Append(spaces);
                            sb.Append(codeLine.Text.Trim());
                            sb.Append(Environment.NewLine);

                            // if the value for increaseIndentNextLine is true
                            if (increaseIndentNextLine)
                            {
                                // increase
                                indent++;
                            }
                        }
                    }
                }

                // Set the return value
                formattedCode = sb.ToString().TrimEnd();
            }

            // return value
            return formattedCode;
        }

    #endregion
    
}
#endregion
