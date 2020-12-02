using System;
using OtpNet;

namespace Authentificator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars1 = "hyh5gt5c5cncvikscx5vlftecoeygy7d";
            var bytes = Base32Encoding.ToBytes(chars1);

            var totp = new Totp(bytes);

            var result = totp.ComputeTotp();
            var remainingTime = totp.RemainingSeconds();
            Console.WriteLine(result);
        }
    }
}
