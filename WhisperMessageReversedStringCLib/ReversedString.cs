using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhisperMessageReversedStringCLib
{
    public class ReversedString : IWhisperMessageReversedString
    {
        public string WhisperReversedString(string message)
        {
            if (message == null)
                throw new ArgumentNullException("Message is not valid");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty");
            

            string[] reversedString = message.Split(' ');
            string result = "";

            foreach (var w in reversedString)
            {
                for (int i = w.Length - 1; i >= 0; i--)
                {
                    if (Char.IsUpper(w[w.Length - 1 - i]))
                        result += w[i].ToString().ToUpper();
                    if (Char.IsLower(w[w.Length - 1 - i]))
                        result += w[i].ToString().ToLower();
                }

                result = result + " ";
            }

            return result.Trim();
        }
    }
}
