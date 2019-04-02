using System;
using System.Collections.Generic;

namespace RSA_Encryption {
  class DiophantineSolver {
    //Multiplikativ inverse
    public static int MI(int a, int b) {
      List<item> table = new List<item>();
      table.Add(new item(a, null, 1, 0));
      table.Add(new item(b, null, 0, 1));
      
      while (true) {
        int r = table[table.Count-2].r % table[table.Count-1].r;
        if (r == 0) break;

        int k = table[table.Count-2].r / table[table.Count-1].r;
        int x = table[table.Count-2].x - k * table[table.Count-1].x;
        int y = table[table.Count-2].y - k * table[table.Count-1].y;

        table.Add(new item(r,k,x,y));
      }

      return table[table.Count-1].x;
    }

    class item {
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
