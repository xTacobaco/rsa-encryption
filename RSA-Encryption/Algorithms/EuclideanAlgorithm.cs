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
    
    //Generera relativit prima tal 2/3 mindre än m.
    public static long Coprime(long m) {
      for (long i=m/4-4; i > 1; --i) {
        if (GCD(i, m) == 1) 
          return i;
      }
      return 0;
    }
  }
}
