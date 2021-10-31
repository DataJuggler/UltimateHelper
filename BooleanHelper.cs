

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class BooleanHelper
    /// <summary>
    /// This 
    /// </summary>
    public class BooleanHelper
    {
        
        #region Methods

            #region ParseBoolean(string sourceString, bool defaultValue, bool errorValue)
            /// <summary>
            /// This method returns the Boolean value for the source string given.
            /// </summary>
            public static bool ParseBoolean(string sourceString, bool defaultValue, bool errorValue)
            {
                // initial value
                bool boolValue = defaultValue;

                try
                {
                    // if the string exists
                    if (TextHelper.Exists(sourceString))
                    {
                        if (TextHelper.IsEqual(sourceString, "1"))
                        {   
                            // one is true
                            boolValue = true;
                        }
                        else if (TextHelper.IsEqual(sourceString, "0"))
                        {
                            // zero is false
                            boolValue = true;
                        }
                        else if (TextHelper.IsEqual(sourceString.ToLower(), "true"))
                        {
                            // true
                            boolValue = true;
                        }
                        else if (TextHelper.IsEqual(sourceString.ToLower(), "false"))
                        {
                            // false
                            boolValue = true;
                        }
                        else
                        {
                            // parse as an int
                            int value = NumericHelper.ParseInteger(sourceString, 0, 0);

                            // if value is not equal to zero
                            if (value != 0)
                            {
                                // any non zero is a true
                                boolValue = true;
                            }
                            else
                            {
                                // perform the parse
                                boolValue = Boolean.Parse(sourceString);        
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();

                    // set the return value to the errorValue
                    boolValue = errorValue;
                }

                // return value
                return boolValue;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
