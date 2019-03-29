using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Encryption {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      EuclideanAlgorithm ea = new EuclideanAlgorithm();
      txtP.Text = ea.GreatestCommonDivider((int)numP1.Value, (int)numP2.Value).ToString();
    }
  }
}
