using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace BOL
{
    public class Encrypted
    {
       public static String GetEncrypted(String pass)
        {
            HashAlgorithm hs = HashAlgorithm.Create("SHA256");
            byte[] bytearray = Encoding.UTF8.GetBytes(pass);
            byte[] encryptedbytes = hs.ComputeHash(bytearray);
            String encryptedpass = Encoding.Unicode.GetString(encryptedbytes);
            return encryptedpass;
        }
    }
}
