﻿

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class NullHelper
    /// <summary>
    /// This class is used to test for nulls without having to type != null.
    /// </summary>
    public class NullHelper
    {
        
        #region Methods
            
            #region Exists(object item)
            /// <summary>
            /// This method returns true if the item exists.
            /// </summary>
            public static bool Exists(object item)
            {
                // initial value
                bool exists = (item != null);

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2)
            /// <summary>
            /// This method returns true if both items exist.
            /// </summary>
            public static bool Exists(object item, object item2)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null));

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2, object item3)
            /// <summary>
            /// This method returns true if all three objects exist.
            /// </summary>
            public static bool Exists(object item, object item2, object item3)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null) && (item3 != null));

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2, object item3, object item4)
            /// <summary>
            /// This method returns true if all four objects exist.
            /// </summary>
            public static bool Exists(object item, object item2, object item3, object item4)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null) && (item3 != null) && (item4 != null));

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2, object item3, object item4, object item5)
            /// <summary>
            /// This method returns true if all five objects exist.
            /// </summary>
            public static bool Exists(object item, object item2, object item3, object item4, object item5)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null) && (item3 != null) && (item4 != null) && (item5 != null));

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2, object item3, object item4, object item5, object item6)
            /// <summary>
            /// This method returns true if all six objects exist.
            /// </summary>
            public static bool Exists(object item, object item2, object item3, object item4, object item5, object item6)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null) && (item3 != null) && (item4 != null) && (item5 != null) && (item6 != null));

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2, object item3, object item4, object item5, object item6, object item7)
            /// <summary>
            /// This method returns true if all seven objects exist.
            /// </summary>
            public static bool Exists(object item, object item2, object item3, object item4, object item5, object item6, object item7)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null) && (item3 != null) && (item4 != null) && (item5 != null) && (item6 != null) && (item7 != null));

                // return value
                return exists;
            }
            #endregion

            #region Exists(object item, object item2, object item3, object item4, object item5, object item6, object item7, object item8)
            /// <summary>
            /// This method returns true if all eight objects exist.
            /// </summary>
            public static bool Exists(object item, object item2, object item3, object item4, object item5, object item6, object item7, object item8)
            {
                // initial value
                bool exists = ((item != null) && (item2 != null) && (item3 != null) && (item4 != null) && (item5 != null) && (item6 != null) && (item7 != null)  && (item8 != null));

                // return value
                return exists;
            }
            #endregion

            #region IsNull(object item)
            /// <summary>
            /// This method returns true if the item does not exist
            /// </summary>
            public static bool IsNull(object item)
            {
                // initial value
                bool isNull = (item == null);

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2)
            /// <summary>
            /// This method returns true if either of the two items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null));

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2, object item3)
            /// <summary>
            /// This method returns true if any of the three items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2, object item3)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null) || (item3 == null));

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2, object item3, object item4)
            /// <summary>
            /// This method returns true if any of the four items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2, object item3, object item4)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null) || (item3 == null) || (item4 == null));

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2, object item3, object item4, object item5)
            /// <summary>
            /// This method returns true if any of the five items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2, object item3, object item4, object item5)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null) || (item3 == null) || (item4 == null) || (item5 == null));

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2, object item3, object item4, object item5, object item6)
            /// <summary>
            /// This method returns true if any of the six items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2, object item3, object item4, object item5, object item6)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null) || (item3 == null) || (item4 == null) || (item5 == null) || (item6 == null));

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2, object item3, object item4, object item5, object item6, object item7)
            /// <summary>
            /// This method returns true if any of the seven items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2, object item3, object item4, object item5, object item6, object item7)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null) || (item3 == null) || (item4 == null) || (item5 == null) || (item6 == null)  || (item7 == null));

                // return value
                return isNull;
            }
            #endregion

            #region IsNull(object item, object item2, object item3, object item4, object item5, object item6, object item7, object item8)
            /// <summary>
            /// This method returns true if any of the eight items Do Not Exist.
            /// </summary>
            public static bool IsNull(object item, object item2, object item3, object item4, object item5, object item6, object item7, object item8)
            {
                // initial value
                bool isNull = ((item == null) || (item2 == null) || (item3 == null) || (item4 == null) || (item5 == null) || (item6 == null) || (item7 == null) || (item8 == null));

                // return value
                return isNull;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
