

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.UltimateHelper.Objects;
using DataJuggler.UltimateHelper.Enumerations;

#endregion

namespace DataJuggler.UltimateHelper
{
    #region class CodeLine
    /// <summary>
    /// This class is used to make it simple to parse code
    /// </summary>
    public class CodeLine
    {
    
        #region Private Variables
        private TextLine textLine;
        private bool blockCommentOn;
        public const string CSharpComment = "//";
        public const string CSharpBlockCommentStart = "/*";
        public const string CSharpBlockCommentEnd = "*/";
        public const string PythonComment = "#";    
        private LanguageEnum language;
        private int indent;
        #endregion
    
        #region Constructor
        /// <summary>
        /// Create a new instance of a CodeLine object
        /// </summary>
        /// <param name="textLine"></param>
        public CodeLine(TextLine textLine, LanguageEnum language, bool blockCommentOn = false)
        {
            // Store the line
            TextLine = textLine;
            Language = language;
            BlockCommentOn = blockCommentOn;
        }
        #endregion

        #region Methods

            #region GetActiveText()
            /// <summary>
            /// returns the Active Text
            /// </summary>
            public string GetActiveText()
            {
                // initial value
                string activeText = "";

                // locals
                int commentCount = 0;
                bool commentOn = false;
                StringBuilder sb = new StringBuilder();

                // if the text exists
                if (HasText)
                {
                    // Iterate the collection of char objects
                    foreach(char c in Text)
                    {
                        // if the comment is on
                        if (!commentOn)
                        {                        
                            // if a forward slash
                            if (c == '/')
                            {
                                // Increment the value for commentCount
                                commentCount++;

                                // if commentCount equals 2
                                if (commentCount == 2)
                                {
                                    // set to true
                                    commentOn = true;
                                }
                            }
                            else if ((commentCount == 1) && (c == '*'))
                            {
                                // set commentOn
                                commentOn = true;
                            }
                            else
                            {
                                // Add this character
                                sb.Append(c);
                            }
                        }
                    }

                    // Set the activeText
                    activeText = sb.ToString();
                }
            
                // return value
                return activeText;
            }
            #endregion
        
        #endregion
    
        #region Properties
        
            #region ActiveText
            /// <summary>
            /// This read only property returns the value of ActiveText. That is code that is not commented out.
            /// </summary>
            public string ActiveText
            {  
                get
                {
                    // initial value
                    string activeText = "";
                
                    // if TextLine exists
                    if (HasTextLine)
                    {
                        if (BlockCommentOn)
                        {
                            // set the return value
                            activeText = "";
                        }
                        else
                        {
                            // Return the activeText
                            activeText = GetActiveText();
                        }
                    }
                
                    // return value
                    return activeText;
                }
            }
            #endregion
        
            #region BlockCommentOn
            /// <summary>
            /// This property gets or sets the value for 'BlockCommentOn'.
            /// CodeHelper handles this when parsing the text.
            /// </summary>
            public bool BlockCommentOn
            {
                get { return blockCommentOn; }
                set { blockCommentOn = value; }
            }
            #endregion
        
            #region HasActiveText
            /// <summary>
            /// This property returns true if the 'ActiveText' exists.
            /// </summary>
            public bool HasActiveText
            {
                get
                {
                    // initial value
                    bool hasActiveText = (!String.IsNullOrEmpty(this.ActiveText));
                
                    // return value
                    return hasActiveText;
                }
            }
            #endregion
        
            #region HasText
            /// <summary>
            /// This property returns true if the 'Text' exists.
            /// </summary>
            public bool HasText
            {
                get
                {
                    // initial value
                    bool hasText = (!String.IsNullOrEmpty(this.Text));
                
                    // return value
                    return hasText;
                }
            }
            #endregion
        
            #region HasTextLine
            /// <summary>
            /// This property returns true if this object has a 'TextLine'.
            /// </summary>
            public bool HasTextLine
            {
                get
                {
                    // initial value
                    bool hasTextLine = (this.TextLine != null);
                
                    // return value
                    return hasTextLine;
                }
            }
            #endregion
        
            #region Indent
            /// <summary>
            /// This property gets or sets the value for 'Indent'.
            /// This value will be set by CodeHelper when you call Format.
            /// </summary>
            public int Indent
            {
                get { return indent; }
                set { indent = value; }
            }
            #endregion
        
            #region Language
            /// <summary>
            /// This property gets or sets the value for 'Language'.
            /// </summary>
            public LanguageEnum Language
            {
                get { return language; }
                set { language = value; }
            }
            #endregion
        
            #region Text
            /// <summary>
            /// This read only property returns the value of Text from the object TextLine.
            /// This is the full text of the line. Use ActiveText to get only text that is not commented out.
            /// </summary>
            public string Text
            {
            
                get
                {
                    // initial value
                    string text = "";
                
                    // if TextLine exists
                    if (TextLine != null)
                    {
                        // set the return value
                        text = TextLine.Text;
                    }
                
                    // return value
                    return text;
                }
            }
            #endregion
        
            #region TextLine
            /// <summary>
            /// This property gets or sets the value for 'TextLine'.
            /// </summary>
            public TextLine TextLine
            {
                get { return textLine; }
                set { textLine = value; }
            }
            #endregion
        
        #endregion
    
    }
    #endregion
}
