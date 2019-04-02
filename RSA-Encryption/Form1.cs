using System;
using System.Windows.Forms;

namespace RSA_Encryption {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      txtP.Text = DiophantineSolver.MI(137, 60).ToString();
    }
  }
}
