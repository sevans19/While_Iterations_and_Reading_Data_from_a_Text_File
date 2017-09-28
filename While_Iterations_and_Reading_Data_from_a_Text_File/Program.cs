using System;
// this is the class that StreamReader is in 
using System.IO;

namespace While_Iterations_and_Reading_Data_from_a_Text_File
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ADD A FILE 
            // 1. open solution explorer
            // 2. right click
            // 3. click add --> new file 
            // 4. add a blank text file (rename) 

            // a streamreader sucks in data out of the file, into the program where it can be proccessed 
            StreamReader myReader = new StreamReader("values.txt");
            string line = "";

            // will iterate through this code as long as the "line" value is not set 
            // to null 

            // NULL VALUE = unknown or indeterminate value
            // (an empty string is not unknown or indeterminable)
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            // the "line" variable will be set to null at the end of the file 

            // failure to close to file will leave it open and prevent other applications
            // from accessing the file 
            myReader.Close();
            Console.ReadLine();
        }
    }
}
