

#region using statements


#endregion

namespace DataJuggler.UltimateHelper.Objects
{

    #region class Replacement
    /// <summary>
    /// This class is used so a list of replacements can be passed in
    /// </summary>
    public class Replacement
    {
        
        #region Private Variables
        private string replaceValue;
        private string searchText;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Replacement' object.
        /// </summary>
        public Replacement(string searchText, string replaceValue)
        {
            // Store the Args
            SearchText = searchText;
            ReplaceValue = replaceValue;
        }
        #endregion

        #region Properties
            
            #region ReplaceValue
            /// <summary>
            /// This property gets or sets the value for 'ReplaceValue'.
            /// </summary>
            public string ReplaceValue
            {
                get { return replaceValue; }
                set { replaceValue = value; }
            }
            #endregion
            
            #region SearchText
            /// <summary>
            /// This property gets or sets the value for 'SearchText'.
            /// </summary>
            public string SearchText
            {
                get { return searchText; }
                set { searchText = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
