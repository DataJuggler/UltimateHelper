

#region using statements

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class FontHelper
    /// <summary>
    /// This class is used to make it simple to find fonts
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class FontHelper
    {
        
        #region Methods
        
            #region SearchForFont(string searchText, float size, FontStyle style = FontStyle.Regular)
            /// <summary>
            /// method returns the first font that Starts With your search text.
            /// </summary>
            public static System.Drawing.Font SearchForFont(string searchText, float size, FontStyle style = FontStyle.Regular)
            {
                // initial value
                Font result = null;

                if (TextHelper.Exists(searchText))
                {
                    // get the installed fonts
                    InstalledFontCollection fonts = new InstalledFontCollection();
                
                    // iterate the fonts
                    foreach (FontFamily family in fonts.Families)
                    {
                        if (family.Name.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                        {
                            // set the return value
                            result = new Font(family, size, style);

                            // break out of the loop
                            break;
                        }
                    }

                    // If nothing was found, use a default
                    if (result == null)
                    {
                        // use a generic font
                        result = new Font(FontFamily.GenericSansSerif, size, style);
                    }
                }

                // return value
                return result;
            }
            #endregion

        #endregion
        
    }
    #endregion

}
