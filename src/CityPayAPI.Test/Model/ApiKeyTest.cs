using System;
using System.Security.Cryptography;
using CityPayAPI.Model;
using Xunit;

namespace CityPayAPI.Test
{
    
    public class ApiKeyTest : IDisposable
    {
        private static int GetHexVal(char hex) {
            int val = hex;
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
        
        private static byte[] HexToByteArray(string hex) {
            if (hex.Length % 2 == 1)
                throw new Exception("odd number of digits");
            byte[] arr = new byte[hex.Length >> 1];
            for (int i = 0; i<hex.Length>> 1; ++i)
                arr[i] = (byte) ((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            return arr;
        }
        
        [Fact]
        public void KeyTest()
        {
            
            // generating a nonce
            // var b = new byte[16];
            // using (var Rnd = RandomNumberGenerator.Create())
            // {
            //     Rnd.GetBytes(b);
            // }

            var nonce = HexToByteArray("acb875aef083de292299bd69fcdeb5c5");
            var lk = "7G79TG62BAJTK669";
            var clientId = "PC2";

            
            var dt = new DateTime(2020, 1, 1, 9, 23, 12);
            var key = new ApiKey(clientId, lk).GenerateKey(nonce, dt);
            Assert.Equal("UEMyOkFDQjg3NUFFRjA4M0RFMjkyMjk5QkQ2OUZDREVCNUM1Ol6Q3tCMPsYvqNhFelRD2zQHYlZquBGCY/6ZpZ0AngTF", key);

        }

        public void Dispose()
        {
        }
    }
}