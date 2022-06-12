using System;

namespace Challenge1
{
    /*Challenge String and its methods
    Challenge 1 – String and its methods

    Now you know the use of various string functions so let’s create a small Console 
    application to practice this.

    Declare a string variable and don’t assign any value to it.

    Print on the console “Please enter your name and press enter”. You can then enter 
    your name or any other valid string like “tutorials.eu”.

    Assign that entered string to the string variable which you have declared initially.

    The program should write on the console that string in Uppercase in the first line, 
    then the same string in Lowercase in the second line. In the third line, it writes 
    on the console the string with no trailing or preceding white space like if string 
    entered as “ tutorials.eu ” it should be written on the console as “tutorials.eu”. 
    And in the last line, it should write the Substring of the entered string on the console.

    These kinds of features are e.g. used when creating a login screen, where the system 
    will cut out trailing or preceding white space or, doesn’t care about the casing of 
    the entered username.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            string inputValue;

            Console.WriteLine("Please enter your name and press enter.");
            inputValue = Console.ReadLine();


            Console.WriteLine($"The uppercase value is: {inputValue.ToUpper()} ");
            Console.WriteLine($"The lowercase value is: {inputValue.ToLower()}");
            Console.WriteLine($"The trimed value is:  {inputValue.Trim()}");
            Console.WriteLine($"The substring value starting at the 3rd character and shows 5 characters is: {inputValue.Substring(2,5)}");
            Console.Read();
        }

        
    }
}
