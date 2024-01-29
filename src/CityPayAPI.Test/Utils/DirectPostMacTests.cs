using System;
using CityPayAPI.Model;
using CityPayAPI.Utils;
using Xunit;
using Xunit.Abstractions;

namespace CityPayAPI.Test.Utils
{
    public class DirectPostMacTests : IDisposable
    {
        public void Dispose() {}

        [Fact]
        public void RandomGenerateAndVerifyMac()
        {
            for (int i = 0; i < 1000; i++)
            {
                string lk = new ApiKey("test", "testLicenceKey").GenerateKey();
                Random rnd = new Random();
                byte[] nonce = new byte[16];
                rnd.NextBytes(nonce);
                string identifier = Guid.NewGuid().ToString();
                string mac = DirectPostMac.Create(lk, nonce, i, identifier);
                Assert.True(DirectPostMac.Validate(lk, nonce, i, identifier, mac));
            }
        }

        [Fact]
        public void CreateTest()
        {
            string mac = DirectPostMac.Create(
                "LK123456789", 
                HexToByteArray.Encode("0123456789ABCDEF"), 
                27595, 
                "OD-12345678");
            
            Assert.Equal("163DBAB194D743866A9BCC7FC9C8A88FCD99C6BBBF08D619291212D1B91EE12E",mac);
        }

        [Fact]
        public void ValidateTest()
        {
            Assert.True(DirectPostMac.Validate(
                "LK123456789", 
                HexToByteArray.Encode("0123456789ABCDEF"), 
                27595, 
                "OD-12345678",
                "163DBAB194D743866A9BCC7FC9C8A88FCD99C6BBBF08D619291212D1B91EE12E" 
                ));
        }
    }
}