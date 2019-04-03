using System;

namespace RSA_Encryption {
  class EuclideanAlgorithm {
    //Största gemensamma delare.
    static int GCD(int a, int b) {
      while (b != 0) {
        int c = a % b;
        a = b;
        b = c;
      }

      return a;
    }

    public static int Coprime(int m) {
      for (int i=m/2; i > 1; i--) {
        if (GCD(i, m) == 1) 
          return i;
      }

      return 0;
    }
  }
}
