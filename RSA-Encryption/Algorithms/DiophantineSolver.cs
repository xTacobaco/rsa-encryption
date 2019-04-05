using System;
using System.Collections.Generic;

namespace RSA_Encryption {
  class DiophantineSolver {
    //Multiplikativ inverse
    public static long MultiplicativeInverse(long a, long b) {
      List<item> table = new List<item>();
      table.Add(new item(a, null, 1, 0));
      table.Add(new item(b, null, 0, 1));
      
      int i;
      while (true) {
        i = table.Count;
        long r = table[i-2].r % table[i-1].r;
        if (r == 0) break;

        long k = table[i-2].r / table[i-1].r;
        long x = table[i-2].x - k * table[i-1].x;
        long y = table[i-2].y - k * table[i-1].y;

        table.Add(new item(r, k, x, y));
        table.RemoveAt(i-2);
      }

      return table[i-1].x;
    }

    struct item {
      public long r, x, y;
      public long? k; 

      public item(long r, long? k, long x, long y) {
        this.r = r;
        this.k = k;
        this.x = x;
        this.y = y;
      }
    }
  }
}
