using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Hello
    {
        public static string Reverse(string raw)
        {
            //Define strings so that the user can enter a string and the computer can process the data
            string editedStr = "";

            //Where the magic happens:
            foreach (char c in raw) //For every individual character in the string,
            {
                editedStr = c + editedStr; //Add the character to the editedStr
            }

            return (editedStr);
        }
    }
}
