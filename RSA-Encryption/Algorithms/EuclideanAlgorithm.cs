using System;

namespace RSA_Encryption {
  class EuclideanAlgorithm {
    //Största gemensamma delare.
    public static int GCD(int a, int b) {
      if (b == 0)
        return a;

      int c = a % b;
      return GCD(b, c);
    }
  }
}
