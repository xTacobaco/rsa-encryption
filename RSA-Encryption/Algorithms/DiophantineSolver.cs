using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption {
  class DiophantineSolver {
    public int TheMultiplicationInverse(int a, int b) {
      int d = 0;
      int x1 = 0;
      int x2 = 1;
      int y1 = 1;
      int tm = b;
    
      while (a > 0) {
          int tmp1 = tm/a;
          int tmp2 = tm - tmp1 * b;
          tm = b;
          b = tmp2;
        
          int x = x2- tmp1* x1;
          int y = d - tmp1 * y1;
        
          x2 = x1;
          x1 = x;
          d = y1;
          y1 = y;
      }

      return d + tm;
    }
  }
}
