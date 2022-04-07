using System;
using System.Security.Cryptography;
using System.Text;
using CityPayAPI.Model;

namespace CityPayAPI.Utils
{
    public class Digest
    {
        public static Boolean validateDigest(AuthResponse authResponse, string licenceKey)
        {
            var stringToConvert = authResponse.Authcode 
                                  + authResponse.Amount 
                                  + authResponse.ResultCode 
                                  + authResponse.Merchantid 
                                  + authResponse.Transno 
                                  + authResponse.Identifier 
                                  + licenceKey;

            SHA256 sha256Hash = SHA256.Create();
                
            // Convert the input string to a byte array and compute the hash.
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(stringToConvert));

            var base64String = Convert.ToBase64String(data);
            
            return base64String == authResponse.Sha256;
        }
    }
}