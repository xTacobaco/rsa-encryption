using System;

namespace RSA_Encryption {
  class EuclideanAlgorithm {
    //Största gemensamma delare.
    static long GCD(long a, long b) {
      while (b != 0) {
        long c = a % b;
        a = b;
        b = c;
      }

      return a;
    }
    
    //Generera ett värde på e.
    public static long GetE(long m, long p, long q) {
      long[] values = new long[] { 3, 5/*, 17*/, 257, 65537 };
      for (int i=values.Length-1; i > 0; i--) {
        if (m < values[i]) continue;
        if (GCD(m, values[i]) != 1) continue;
        if (p % values[i] == 1) continue;
        if (q % values[i] == 1) continue;
        return values[i];
      }

      return 0;
    }
  }
}
