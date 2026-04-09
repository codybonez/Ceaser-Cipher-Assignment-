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
            
            char[] c;
            // loop that goes through and checks each character in the message
            for (int i = 0; i < message.Length; i++)
            {
               
                c = message.ToCharArray();

               
                c[i] = (char)(c[i] + key);
              
                
                    
                    
                message = new string(c);
                    
                 
                    
                    
                    
                
               
            }
            return message;
        }
        public string CeaserCipherEncryptBackward(int key, string message)
        {
            char[] c;

            for (int i = 0; i <message.Length; i++)
            {
                c = message.ToCharArray();
                c[i] = (char)(c[i] - key);
                while (!char.IsLetter(c[i]))
                {
                    if (char.IsLetter(c[i]))
                    {
                        message = new string(c);
                    }
                    else
                    {
                        c[i] = (char)(c[i] -1);
                    }
                }
                message = new string(c);
            }
            return message;
        }
    }
}
