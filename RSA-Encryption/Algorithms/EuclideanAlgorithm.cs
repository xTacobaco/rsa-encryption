using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption {
  class EuclideanAlgorithm {
        //Värdena som kommer in är: Första gången är m och e
    public int GreatestCommonDivider(int a, int b) {
      int k = a / b; //imed k hugger bort allt efter decimaltecknet
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
