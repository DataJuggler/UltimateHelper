

#region using statements

using System;
using System.Collections.Generic;

#endregion

namespace DataJuggler.UltimateHelper.Objects
{

    #region class TextLine
    /// <summary>
    /// This class represents one line of Text.
    /// </summary>
    public class TextLine
    {
        
        #region Private Variables
        private string text;
        private List<Word> words;
        private int lineNumber;
        private int index;
        private string tag;
        private int top;
        #endregion

        #region Constructors

            #region Default Constructor
            /// <summary>
            /// Create a new instance of a TextLine object.
            /// </summary>
            public TextLine()
            {
                
            } 
            #endregion

            #region Parameterized Constructor
            /// <summary>
            /// Create a new instance of a TextLine object and set the Text property
            /// </summary>
            public TextLine(string text)
            {
                // Set the Text property
                this.Text = text;
            }
            #endregion

        #endregion

        #region Methods
            
            #region ToString()
            /// <summary>
            /// This method returns the Text of this object when ToString is called.
            /// </summary>
            public override string ToString()
            {
                // return the Text when ToString is called.
                return Text;
            }
            #endregion
            
        #endregion
      
        #region Properties

            #region ContainsPartialComment
            /// <summary>
            /// This read only property returns the value for 'ContainsPartialComment'.
            /// </summary>
            public bool ContainsPartialComment
            {
                get
                {
                    // initial value
                    bool containsPartialComment = false;
                    
                    // A line cannot be a comment and a partial comment. It's one or the other, or not for both.
                    if ((HasText) && (!IsComment))
                    {
                        // set the return value
                        containsPartialComment = this.Text.Contains("//");
                    }
                    
                    // return value
                    return containsPartialComment;
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
                    bool hasText = !String.IsNullOrEmpty(this.Text);
                    
                    // return value
                    return hasText;
                }
            }
            #endregion
            
            #region HasWords
            /// <summary>
            /// This property returns true if this object has a 'Words'.
            /// </summary>
            public bool HasWords
            {
                get
                {
                    // initial value
                    bool hasWords = (this.Words != null);
                    
                    // return value
                    return hasWords;
                }
            }
            #endregion
            
            #region Index
            /// <summary>
            /// This property gets or sets the value for 'Index'.
            /// </summary>
            public int Index
            {
                get { return index; }
                set { index = value; }
            }
            #endregion
            
            #region IsComment
            /// <summary>
            /// This read only property returns true, if the first text in this line is a C# comment '//'.
            /// Comments that appear later in the line are not counted in this method, use ContainsComment
            /// to check if a line contains any comment, and UncommentedText to get the text before
            /// a comment. If there is not a comment, UncommentedText returns the same as Text.
            /// </summary>
            public bool IsComment
            {
                get
                {
                    // initial value
                    bool isComment = false;
                    
                    // if the value for HasText is true
                    if (HasText)
                    {
                        // if hasText is true
                        isComment = this.Text.Trim().StartsWith("//");
                    }
                    
                    // return value
                    return isComment;
                }
            }
            #endregion
            
            #region LineNumber
            /// <summary>
            /// This property gets or sets the value for 'LineNumber'.
            /// </summary>
            public int LineNumber
            {
                get { return lineNumber; }
                set { lineNumber = value; }
            }
            #endregion

            #region PartialCommentCode
            /// <summary>
            /// This read only property returns the value for 'PartialCommentCode'.
            /// The PartialCommentCode is the code before the comment in a line
            /// that contains a partial comment.
            /// </summary>
            public string PartialCommentCode
            {
                get
                {
                    // initial value
                    string partialCommentCode = "";

                    // if this line contains a partial comment
                    if (ContainsPartialComment)
                    {
                        // get the index of the comment
                        int index = Text.IndexOf("//");

                        // Set the return value
                        partialCommentCode = Text.Substring(0, index);

                        // just in case the comment lines are here, remove it.
                        partialCommentCode = partialCommentCode.Replace("//", "");
                    }
                    
                    // return value
                    return partialCommentCode;
                }
            }
            #endregion
            
            #region PartialCommentText
            /// <summary>
            /// This read only property returns the value for 'PartialCommentText'.
            /// The PartialCommentText is the text that is commented out, in a line
            /// that contains a PartialComment. Does not take into account block comments such as /* */
            /// </summary>
            public string PartialCommentText
            {
                get
                {
                    // initial value
                    string partialCommentText = "";

                    // if this line contains a partial comment
                    if (ContainsPartialComment)
                    {
                        // get the index of the comment
                        int index = Text.IndexOf("//");

                        // Set the return value
                        partialCommentText = Text.Substring(index).Replace("//", "").Trim();
                    }
                    
                    // return value
                    return partialCommentText;
                }
            }
            #endregion
            
            #region Tag
            /// <summary>
            /// This property gets or sets the value for 'Tag'.
            /// </summary>
            public string Tag
            {
                get { return tag; }
                set { tag = value; }
            }
            #endregion
            
            #region Text
            /// <summary>
            /// This property gets or sets the value for 'Text'.
            /// </summary>
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            #endregion
            
            #region Top
            /// <summary>
            /// This property gets or sets the value for 'Top'.
            /// This is only used in PixelDatabase.NET to convert text into lines.
            /// </summary>
            public int Top
            {
                get { return top; }
                set { top = value; }
            }
            #endregion
            
            #region Words
            /// <summary>
            /// This property gets or sets the value for 'Words'.
            /// </summary>
            public List<Word> Words
            {
                get { return words; }
                set { words = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
