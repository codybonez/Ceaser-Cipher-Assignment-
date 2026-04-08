using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ceaser_Cipher_Assignment
{
    public class Cipher
    {
        public string CeaserCipherEncryptFoward(int key, string message)
        {
            char c;
            // loop that goes through and checks each character in the message
            for (int i = 0; i < message.Length; i++)
            {
                c = (char)message.Length;
                for (int j = 0; j < key; j++)
                {
                 // assigns the current character in the message to increment by the key


                }
            }
            // 


            
            
             
            
        return message;
        }
        public string CeaserCipherEncryptBackward(int key, string message)
        {
            return message;
        }
    }
}
