using System;

namespace RSA_Encryption {
  class Encryption {
    public static bool isPrime(long num) {
      if (num % 2 == 0 && num != 2 || num <= 1)
        return false;

      for (long i = 3; i < Math.Pow(num, 0.5) + 1; i += 2) {
        if (num % i == 0)
          return false;
      }

      return true;
    }

    public static string Encrypt(Tuple<long, long> publicKey, long input) {
      return (Math.Pow(input, publicKey.Item1) % publicKey.Item2).ToString();
    }

    public static string Decrypt(Tuple<long, long> privateKey, long input) {
      return (Math.Pow(input, privateKey.Item2) % privateKey.Item1).ToString();
    }
  }
}
