

#region using statements

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DataJuggler.UltimateHelper
{

    #region class FolderHelper
    /// <summary>
    /// This class is designed to assist in directory related tasks.
    /// </summary>
    public class FolderHelper
    {
        
        #region Methods

            #region Exists(string path)
            /// <summary>
            /// returns the
            /// </summary>
            public static bool Exists(string path)
            {
                // return true if the text Path exists and the Directory exists on disc
                bool exists = ((TextHelper.Exists(path)) && (Directory.Exists(path)));

                // return value
                return exists;
            }
            #endregion
            
            #region FindParentDirectory(string path, string name, int maxParents = 10)
            /// <summary>
            /// returns the Parent Directory, or EmptyString if not found.
            /// </summary>
            public static string FindParentDirectory(string path, string name, int maxParents = 10)
            {
                // initial value
                string parentPath = "";

                // local
                int count = 0;

                // verify the path exists
                if (Directory.Exists(path))
                {
                    // Create a new instance of a 'DirectoryInfo' object.
                    DirectoryInfo directoryInfo = new DirectoryInfo(path);

                    do
                    {
                        // try
                        count++;

                        // Set the parent
                        DirectoryInfo parent = directoryInfo.Parent;

                        // If the parent object exists
                        if (NullHelper.Exists(parent))
                        {
                            // if this folder is the folder being sought
                            if (TextHelper.IsEqual(parent.Name, name, true))
                            {
                                // Set the FullName
                                parentPath = parent.FullName;

                                // exit
                                break;
                            }
                            else
                            {
                                // Reset
                                directoryInfo = new DirectoryInfo(parent.FullName);
                            }
                        }
                        else
                        {
                            // bail
                            break;
                        }

                    } while (count < maxParents);
                }
                
                // return value
                return parentPath;
            }
            #endregion
            
            #region GetFolders(string folder)
            /// <summary>
            /// returns a list of Folders
            /// </summary>
            public static List<string> GetFolders(string folder)
            {
                // initial value
                List<string> folders = null;

                // if the Folder exists
                if (Exists(folder))
                {
                    // Set the return value
                    folders = Directory.GetDirectories(folder).ToList();
                }

                // return value
                return folders;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
