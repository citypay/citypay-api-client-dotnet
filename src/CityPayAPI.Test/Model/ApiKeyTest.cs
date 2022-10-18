using System;
using System.Security.Cryptography;
using CityPayAPI.Model;
using CityPayAPI.Utils;
using Xunit;

namespace CityPayAPI.Test
{
    
    public class ApiKeyTest : IDisposable
    { 
        [Fact]
        public void KeyTest()
        {
            
            // generating a nonce
            // var b = new byte[16];
            // using (var Rnd = RandomNumberGenerator.Create())
            // {
            //     Rnd.GetBytes(b);
            // }

            var nonce = HexToByteArray.Encode("acb875aef083de292299bd69fcdeb5c5");
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
