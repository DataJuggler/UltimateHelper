using System;
using System.Collections.Generic;
using System.Text;

namespace DataJuggler.UltimateHelper
{
    public class EnvironmentVariableHelper
    {

        #region Methods

            #region GetEnvironmentVariableValue(string variableName)
            /// <summary>
            /// This method is used to get an environment value
            /// </summary>
            /// <param name="variableName"></param>
            /// <returns></returns>
            public static string GetEnvironmentVariableValue(string variableName)
            {
                // initial value
                string value = "";

                try
                {
                    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                    {
                        // Change the directory to %WINDIR%
                        value = Environment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.Machine);
                    }
                }
                catch (Exception error)
                {
                    // for debugging only, do something else with it if you need to
                    DebugHelper.WriteDebugError("GetEnvironmentVariableValue", "GetEnvironmentVariableValue", error);
                }

                // return value
                return value;
            }
            #endregion

        #endregion

    }
}
