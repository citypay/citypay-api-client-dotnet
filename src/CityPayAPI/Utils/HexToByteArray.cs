using System;

namespace CityPayAPI.Utils
{
    /// <summary>
    /// HexToByteArray
    /// </summary>
    public class HexToByteArray
    {
        private static int GetHexVal(char hex) {
            int val = hex;
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
        
        /// <summary>
        /// Encode Hex to Byte[]
        /// </summary>
        /// <param name="hex"></param>
        /// <returns>byte[]</returns>
        /// <exception cref="Exception"></exception>
        public static byte[] Encode(string hex) {
            if (hex.Length % 2 == 1)
                throw new Exception("odd number of digits");
            byte[] arr = new byte[hex.Length >> 1];
            for (int i = 0; i<hex.Length>> 1; ++i)
                arr[i] = (byte) ((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            return arr;
        }
    }
}