﻿using System;
using System.Windows.Forms;

namespace RSA_Encryption {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void calcMI(object sender, EventArgs e) {
      txtP.Text = DiophantineSolver.MI((int)numP1.Value, (int)numP2.Value).ToString();
    }

    private void Form1_Load(object sender, EventArgs e) {
      txtP.Text = EuclideanAlgorithm.GCD(20,25).ToString();
    }
  }
}
