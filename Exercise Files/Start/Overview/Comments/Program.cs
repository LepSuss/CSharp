using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// this is the main sample application function
        /// </summary>   
        /// <param name='args'> An array of string arguments from the command line</param>
        /// <returns>
        /// doesn not return any value
        /// </returns> 
        static void Main(string[] args)
        {
            // single line comment
            // another one
            Console.WriteLine("Hello World!");
            /* multiple line comment 
            this can continue for several lines*/
        }
    }
}
