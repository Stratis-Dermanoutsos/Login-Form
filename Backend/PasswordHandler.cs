using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LoginForm.Backend
{
    static class PasswordHandler
    {
        // Basic function to hash a string
        public static string GetSha512(string value)
        {
            var data = Encoding.UTF8.GetBytes(value);
            var hashData = new SHA512Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }
            return hash;
        }
    }
}
