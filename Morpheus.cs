#region using statements

using System.Text;
using System.Security.Cryptography;
using System.Text.Json;
using DataJuggler.UltimateHelper;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class Morpheus
    /// <summary>
    /// This class is used to determine if an object has changes or not.
    /// </summary>
    public static class Morpheus
    {
        #region Methods

            #region Serialize(object obj)
            /// <summary>
            /// Serializes an object into a hash string for change detection.
            /// </summary>
            /// <param name="obj">The object to serialize.</param>
            /// <returns>A hash string representing the object's state, or empty string if null.</returns>
            public static string Serialize(object obj)
            {
                // Initial value
                string serialized = string.Empty;

                // If the obj object exists
                if (NullHelper.Exists(obj))
                {
                    string json = JsonSerializer.Serialize(obj);
                    using (var md5 = MD5.Create())
                    {
                        byte[] inputBytes = Encoding.UTF8.GetBytes(json);
                        byte[] hashBytes = md5.ComputeHash(inputBytes);
                        serialized = Convert.ToHexString(hashBytes); // 32-char hex string
                    }
                }

                // Return value
                return serialized;
            }
            #endregion

            #region Compare(object obj, string hash)
            /// <summary>
            /// Compares an object's current state to a previously serialized hash.
            /// </summary>
            /// <param name="obj">The object to compare.</param>
            /// <param name="hash">The hash string to compare against.</param>
            /// <returns>True if the object matches the hash (unchanged), false otherwise.</returns>
            public static bool Compare(object obj, string hash)
            {
                // Initial value
                bool isMatch = false;

                // if the object exists and the hash exists
                if ((NullHelper.Exists(obj)) && (TextHelper.Exists(hash)))
                {
                    // Get the new hash
                    string newHash = Serialize(obj);

                    // Is this a match
                    isMatch = (TextHelper.IsEqual(newHash, hash));
                }

                // Return value
                return isMatch;
            }
            #endregion

        #endregion
    }
    #endregion

}