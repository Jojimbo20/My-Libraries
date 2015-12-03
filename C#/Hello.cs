﻿using System;
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

        public static bool isPalindrome(int x)
        {
            //I declared two strings, one to store the unchanged number
            //One to store the reversed number
            string unReversed = x.ToString();
            string Reversed = Hello.Reverse(unReversed);

            //Because I can't figure out how to compare strings I'm gonna compare the ints
            int reversedInt = Convert.ToInt32(Reversed);

            //If the reversed one and the normal one are th e same it's a palindrome
            if (x == reversedInt)
            {
                return (true);
            }

            else
                return (false);
        }
        public static bool isPrime(int x)
        {
            if (x == 1)
            {
                return (true); 
            }
            //Counts up to the number
            for(int i = 1; i < x; ++i)
            {
                //if it's divisible by any of the numbers below it then return that its not a prime
                if( x / i == 0)
                {
                    return (false);
                }

            }
            return (true);
        }
        public static string Encrypt(string rawTxt, int shiftNum)
        {
            //Create a character array that stores the string chars
            char[] storage = rawTxt.ToCharArray();
            char[] shifted = new char[rawTxt.Length];

            //This is a looper that will shift up to one less than the length of the string.
            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == ' ')
                {
                    continue;
                }
                //For each loop, single becomes one element of the string
                char single = rawTxt[i];

                //This applies the shift to the individual char
                single = (char)(single + shiftNum);

                //These handle overflow and underflow
                if (single > 'z')
                {
                    single = (char)(single - 26);
                }
                else if (single < 'a')
                {
                    single = (char)(single + 26);
                }

                //Store the shifted value
                shifted[i] = single;
            }

            //convert the char array into a string and return that value.
            return new string(shifted);	
        }
    }
}
