using System;

namespace RSA_Encryption {
  class EuclideanAlgorithm {
    //Största gemensamma delare.
    public static int GCD(int a, int b) {
      if (b == 0)
        return a;

      while (b != 0) {
        int c = a % b;
        a = b;
        b = c;
      }

      return a;
    }
  }
}
