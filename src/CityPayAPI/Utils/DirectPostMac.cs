using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace CityPayAPI.Utils
{
    /// <summary>
    /// DirectPostMac
    /// </summary>
    public class DirectPostMac
    {
        /// <summary>
        /// Validates Mac
        /// </summary>
        /// <param name="licenceKey">The licence key provided</param>
        /// <param name="nonce">Nonce provided</param>
        /// <param name="amount">Amount provided</param>
        /// <param name="identifier">Identifier provided</param>
        /// <param name="macToValidate">Mac to validate</param>
        /// <returns></returns>
        public static bool Validate(string licenceKey, byte[] nonce, int amount, string identifier, string macToValidate)
        {
            string mac = Create(licenceKey, nonce, amount, identifier);
            return mac == macToValidate;
        }

        /// <summary>
        /// Creates Mac
        /// </summary>
        /// <param name="licenceKey">The licence key provided</param>
        /// <param name="nonce">Nonce provided</param>
        /// <param name="amount">Amount provided</param>
        /// <param name="identifier">Identifier provided</param>
        /// <returns>string</returns>
        public static string Create(string licenceKey, byte[] nonce, int amount, string identifier)
        {
            string value = BitConverter.ToString(nonce).Replace("-", "") + amount + identifier;
            
            UTF8Encoding utf8 = new UTF8Encoding();
            HMACSHA256 hash = new HMACSHA256(utf8.GetBytes(licenceKey));
            
            byte[] bytes = Encoding.UTF8.GetBytes(value);

            return BitConverter.ToString(hash.ComputeHash(bytes)).Replace("-", "");
        }
    }
}