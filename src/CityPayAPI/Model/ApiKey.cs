using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CityPayAPI.Model
{
    public class ApiKey
    {
        public ApiKey(string clientId, string licenceKey)
        {
            ClientId = clientId;
            LicenceKey = licenceKey;
        }

        public string ClientId { get; }
        public string LicenceKey { get; }

        public string GenerateKey(byte[] nonce)
        {
            return GenerateKey(nonce, DateTime.Now);
        }
        
        public string GenerateKey(byte[] nonce, DateTime dt)
        {
            StringBuilder hexNonce = new StringBuilder();
            foreach (byte b in nonce)
                hexNonce.Append(b.ToString("X2"));

            var ds = Digest(nonce, dt);
            
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter bw = new BinaryWriter(stream))
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    bw.Write(utf8.GetBytes(ClientId));
                    bw.Write((byte)0x3A);
                    bw.Write(utf8.GetBytes(hexNonce.ToString()));
                    bw.Write((byte)0x3A);
                    bw.Write(ds);
                }

                var bs = stream.ToArray();
                return Convert.ToBase64String(bs);
            }
            
        }

        private byte[] Digest(byte[] nonce, DateTime dt)
        {
            var ds = dt.ToString("yyyyMMddHHmm");
            var hx = new byte[ds.Length / 2];
            for (int i = 0; i < ds.Length; i += 2)
                hx[i / 2] = Convert.ToByte(ds.Substring(i, 2), 16);

            UTF8Encoding utf8 = new UTF8Encoding();
            var c1 = utf8.GetBytes(ClientId);

            byte[] bs = new byte[hx.Length + c1.Length + nonce.Length];
            Buffer.BlockCopy(c1, 0, bs, 0, c1.Length);
            Buffer.BlockCopy(nonce, 0, bs, c1.Length, nonce.Length);
            Buffer.BlockCopy(hx, 0, bs, c1.Length + nonce.Length, hx.Length);

            HMACSHA256 hash = new HMACSHA256(utf8.GetBytes(LicenceKey));
            return hash.ComputeHash(bs);
        }
    }
}