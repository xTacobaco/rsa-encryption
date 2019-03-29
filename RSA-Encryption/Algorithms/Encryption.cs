using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption {
  class Encryption {
    public int ChoosePrimes() {
      return 0;
      int p, q, n, m, e = 2;
      //De två primtalen väljs:
      //p=Val ett
      //q=Val två
      if (p == q) {
        Console.WriteLine("p och q kan ej vara samma tal");
      } else {
        n = p * q;
        //m = (p - 1)(q - 1);
        //Skicka iväg m och e till euklides
        //Om de är relativt prima så skicka bara tillbaka dem eller höj e där
      }

    }
  }
}
