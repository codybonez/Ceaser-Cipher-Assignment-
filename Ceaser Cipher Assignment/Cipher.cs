using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Ceaser_Cipher_Assignment
{
    public class Cipher
    {
        public string CeaserCipherEncryptFoward(int key, string message)
        {
            key = (key % 26);
            if (key < 0)
            {
                key += 26;
            }
           
           StringBuilder builder = new StringBuilder();
            
            // loop that goes through and checks each character in the message

            foreach (var c in message)
            { 

                if (char.IsLetter(c))
                {
                    // checks to see if the letter is upercase or lowercase

                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char shifted = (char)((((c - baseChar) + key) % 26) + baseChar);
                    builder.Append(shifted);
                }
                else
                {
                    builder.Append(c);
                }


            }
                    
            
            return builder.ToString();
        }
        public string CeaserCipherEncryptBackward(int key, string message)
        {
           

            return CeaserCipherEncryptFoward(-key, message);



        }
    }
}
