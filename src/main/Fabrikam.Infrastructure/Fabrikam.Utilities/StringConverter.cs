using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam.Utilities
{
    public class StringConverter
    {
        public static byte[] GetMessageByte(string message)
        {
            return Encoding.UTF8.GetBytes(message);
        }

        public static string GetMessage(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }
    }
}
