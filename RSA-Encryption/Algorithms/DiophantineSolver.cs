using System;
using System.Collections.Generic;

namespace RSA_Encryption {
  class DiophantineSolver {
    //Multiplikativ inverse
    public static Tuple<int, int> MI(int a, int b) {
      List<item> table = new List<item>();
      table.Add(new item(a, null, 1, 0));
      table.Add(new item(b, null, 0, 1));
      
      int i;
      while (true) {
        i = table.Count;
        int r = table[i-2].r % table[i-1].r;
        if (r == 0) break;

        int k = table[i-2].r / table[i-1].r;
        int x = table[i-2].x - k * table[i-1].x;
        int y = table[i-2].y - k * table[i-1].y;

        table.Add(new item(r, k, x, y));
        table.RemoveAt(i-2);
      }

      return Tuple.Create(table[i-1].x, table[i-1].y);
    }

    struct item {
      public int r, x, y;
      public int? k; 

      public item(int r, int? k, int x, int y) {
        this.r = r;
        this.k = k;
        this.x = x;
        this.y = y;
      }
    }
  }
}
