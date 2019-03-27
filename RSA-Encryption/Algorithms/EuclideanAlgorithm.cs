using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption {
  class EuclideanAlgorithm {
    public int GreatestCommonDivider(int a, int b) {
      int k = a / b; //k = a / b
      int r = a - k * b;
      
      while (r > 0) {
          a = b;
          b = r;
            
          k = a / b;
          r = a - k * b;
      }

      return b;
    }
  }
}
