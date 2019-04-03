using System;
using System.Windows.Forms;

namespace RSA_Encryption {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void txtKeyChanged(object sender, EventArgs e) {
            bool state = txtPrivateKey.Text != "" && txtPublicKey.Text != "";
            btnDecrypt.Enabled = state;
            btnEncrypt.Enabled = state;
        }

        private void numValueChanged(object sender, EventArgs e) {
            int p1 = (int)numPrime1.Value;
            int p2 = (int)numPrime2.Value;

            if (!Encryption.isPrime(p1) && !Encryption.isPrime(p2)) {
                txtLog.Text += $"( - ) Warning: neither {p1} or {p2} is a prime number." + "\n";
            } else if (!Encryption.isPrime(p1)) {
                txtLog.Text += $"( - ) Warning: {p1} is not a prime number." + "\n";
            } else if (!Encryption.isPrime(p2)) {
                txtLog.Text += $"( - ) Warning: {p2} is not a prime number." + "\n";
            }
        }

        private void btnGenerateClick(object sender, EventArgs e) {
            int p1 = (int)numPrime1.Value;
            int p2 = (int)numPrime2.Value;

            if (p1 == p2) {
                MessageBox.Show($"Faulty input: Prime number #1 cannot equal prime number #2.");
                return;
            }

            if (!Encryption.isPrime(p1) && !Encryption.isPrime(p2)) {
                MessageBox.Show($"Faulty input: {p1} nor {p2} are prime number.");
                return;
            } else if (!Encryption.isPrime(p1)) {
                MessageBox.Show($"Faulty input: {p1} is not a prime number.");
                return;
            } else if (!Encryption.isPrime(p2)) {
                MessageBox.Show($"Faulty input: {p2} is not a prime number.");
                return;
            }

            if (p1 + p2 == 5) {
                MessageBox.Show($"Faulty input: Prime numbers 2 and 3 cannot be used together.");
                return;
            }

            int n = p1 * p2;
            int m = (p1 - 1) * (p2 - 1);
            txtLog.Text += $"( + ) p = {p1}, q = {p2}, n = {n}, m = {m}\n";
            int cp = EuclideanAlgorithm.Coprime(m);
            txtLog.Text += $"( + ) e = {cp}\n";
            txtLog.Text += $"( + ) d = {DiophantineSolver.MultiplicativeInverse(m, cp).Item1}\n";
        }
    }
}
