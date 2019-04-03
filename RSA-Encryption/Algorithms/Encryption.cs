using System;

namespace RSA_Encryption {
  class Encryption {
    public static bool isPrime(int num) {
      if (num % 2 == 0 && num != 2 || num <= 1)
        return false;

      for (int i = 3; i < Math.Pow(num, 0.5) + 1; i += 2) {
        if (num % i == 0)
          return false;
      }

      return true;
    }

    public static void Encrypt() {

    }

    public static void Decrypt() {

    }
  }
}
