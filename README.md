# UltimateHelper
This library is a collection of helper classes that make working with C# much easier.

This package was originally for .Net Framework, then ported to .Net Core, .NET, .NET6, .NET 7
and now .NET8.

# News

2.23.2025: Added a new class called Morpheas

This class is used to determine if an object has changes.

    // generate a hash
    string hash = Morpheas.Serialize(obj);

    // has this object changed
    bool hasChanges = Morpheas.Compare(obj, hash)';

I use to enable button for Save if an object has changes.

2.17.2025: I added a new method to FolderHelper Exists

    bool Exists(string path);

1.22.2025: Added a new method to TextHelper

	FindTextInQuotes(string input)

1.21.2025: Two new methods to TextHelper:

    ReplaceTextInFile(string fileName, string textToFind, string replacementText)

	ReplaceTextInFile(string fileName, List<Replacement> replacements

A Replacement is just a class with two properties: SearchText and ReplacementValue

11.12.2024: I updated the project to .NET 9.

9.2.2024: I fixed a bug with GetTextLines in case the text just has \r, instead of \r\n for new lines.

8.14.2024: I changed NumericHelper.RoundDown and RoundUp to now take into account digits.

1.16.2024: The description was wrong for this project. I had forgot to change the description to, This project has been updated to .NET 8.

12.14.2023: I added a new method CloneLines to TextHelper. This method create a new List of TextLine objects,
and copies the text from the source parameter. This is used by DataJuggler.RandomUSD. 

11.20.2023: Added a new method to TextHelper - ExportWords.
I also added a new property Index to Word and TextLine objects, and set the value for Index
when GetWords and GetTextLines is called.

11.14.2023: This project has been updated to .NET 8.

8.29.2023: I added a new method to NumericHelper - DivideDoublesAsDecimals.
.NET does not handle division by doubles very well, so this method casts the doubles given
to decimals, and returns the quotient as a double.

8.14.2023 New Video

Create a Stock Predictor With C# and ML.NET Part I
https://youtu.be/hF8LkvwOXQY

8.13.2023 - Added a new method to TextHelper - GetTextLinesFromFile. I also modified the method
GetTextLines, to have an option to parse the words foreach line. The new method GetTextLinesFromFile
reads the text from the file, and then calls GetTextLines with optional parameters to also get the words
and pass in your own delimiter. I also added an icon (png) for the project.

8.11.2023 - Added a new method to DateHelper - ParseEightDigitDate.

# Working Examples - Opensource Projects Using This Project

# Blazor Gallery
Blazor Gallery is a complete C# / SQL Server image portfolio site

Live Site
https://blazorgallery.com

Code:
https://github.com/DataJuggler/BlazorGallery

Video:

Is There 1 Brave C# Programmer In The World? 
https://youtu.be/HAMgeaCuvHY

8.11.2023: Blazor Gallery has not received a star yet.

# Blazor Excelerate

Code Generate C# Classes From Excel Header Rows

Live Site
https://excelerate.datajuggler.com

Code:
https://github.com/DataJuggler/Blazor.Excelerate

Blazor Excelerate uses Nuget package DataJuggler.Excelerate, which allows you to load and 
save entire worksheets and workbooks with a few lines of code. 

List of classes:

# BooleanHelper
Parses booleans and allows you set to a default value.

# CodeHelper
Used in formatting code. An example of this is in the live site https://codopy.com,
which is an opensource project here: https://github.com/DataJuggler/Codopy
Format C# Code From Visual Studio when pasting to Git Hub read me files, or the social media.

# CodeLine

A code line is a line of C# code. This class is used in conjunction with TextLine.cs and CodeHelper.cs

# ConfigurationHelper

This class reads app settings from an app.config or web.config. This was created for .NET Framework, but still works.

# DateHelper

This class has methods to help parse dates safely.

# EnumHelper

This class make it easier to parse and iterate enumerations.

# EnvironmentVariableHelper

This class makes it simple to get and set values for System, User or Process Environment Variables.

# FileHelper

This class has many method that help with dealing with files, such as get all files recursively
from a folder, create a file name with a partial guid to ensure uniqueness in a folder and more.

# ListHelper

This class is a must for anyone who deals with Lists or List<T>. 
My two favorite methods are HasOneOrMoreItems and HasXOrMoreItems.

# NullHelper

Check if multiple objects at once with NullHelper.Exists(object1, object2, object3, object4, object5);

# NumericHelper

This class started as a way to parse int's, double's and decimal's, however it has evolved since
and has many helpful methods such as EnsureInRange and IsInRange and more.

# TextHelper

This is one of my favorite classes. TextHelper.Exists(string1, string2, string3, string4) is much 
easier to write than if ((!String.IsNullOrEmpty(string1)) && ((!String.IsNullOrEmpty(string2)) &&
(!String.IsNullOrEmpty(string3)) && (!String.IsNullOrEmpty(string4))). Also there are methods
such as CapitalizeFirstChar, GetTextLines, GetWords, StartsWithVowel, and more.

# XmlPatternHelper

This class is used to encode and decode xml text if the
file contains ampersands (&) or greater than or less than signs.

This class is used by Regionizer and Regionizer2022 Visual Studio Extensions, where the
custom comment dictionary has to be able to save < > and &'s in Xml.


