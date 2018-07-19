using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string RotatedString = "";
            for(int i=0;i<text.Length;i++)
            {
                int test = (int)text[i];
                if (test >= 65 && test <= 90)
                {
                    RotatedString += (char)((int)((test + shiftKey-65) % 26+65));
                }
                else if (test >= 97 && test <= 122)
                {
                    RotatedString += (char)((int)((test + shiftKey - 97) % 26 + 97));
                }
                else
                    RotatedString += text[i];
            }
            return RotatedString;
           
        }
    }
}
