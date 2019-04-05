using System;
using System.Windows.Forms;

namespace RSA_Encryption {
  public partial class Form1 : Form {

    Tuple<long, long> privateKey;
    Tuple<long, long> publicKey;

    public Form1() {
      InitializeComponent();
    }

    private void txtKeyChanged(object sender, EventArgs e) {
      bool state = txtPrivateKey.Text != "" && txtPublicKey.Text != "";
      btnDecrypt.Enabled = state;
      btnEncrypt.Enabled = state;
    }

    private void numValueChanged(object sender, EventArgs e) {
      long p1 = (long)numPrime1.Value;
      long p2 = (long)numPrime2.Value;

      if (!Encryption.isPrime(p1) && !Encryption.isPrime(p2)) {
        txtLog.Text += $"( - ) Warning: neither {p1} or {p2} is a prime number." + "\n";
      } else if (!Encryption.isPrime(p1)) {
        txtLog.Text += $"( - ) Warning: {p1} is not a prime number." + "\n";
      } else if (!Encryption.isPrime(p2)) {
        txtLog.Text += $"( - ) Warning: {p2} is not a prime number." + "\n";
      }
    }

    private void btnGenerateClick(object sender, EventArgs e) {
      long p1 = (long)numPrime1.Value;
      long p2 = (long)numPrime2.Value;

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

      long n = p1 * p2;
      long m = (p1 - 1) * (p2 - 1);
      txtLog.Text += $"( + ) p = {p1}, q = {p2}, n = {n}, m = {m}\n";
      long cp = EuclideanAlgorithm.GetE(m, p1, p2);

      if (cp == 0) {
        txtLog.Text += $"( - ) Error: e = {cp} \n";
        MessageBox.Show($"Faulty input: Prime numbers {p1} and {p2} cannot be used together.");
        return;
      }

      txtLog.Text += $"( + ) e = {cp}\n";
      long d = DiophantineSolver.MultiplicativeInverse(cp, m);
      txtLog.Text += $"( + ) d = {d}\n";

      privateKey = Tuple.Create(n, d);
      publicKey = Tuple.Create(cp, n);

      txtPrivateKey.Text = privateKey.ToString();
      txtPublicKey.Text = publicKey.ToString();
    }

    private void btnEncrypt_Click(object sender, EventArgs e) {
      txtLog.Text += $"( + ) Encrypting {txtInput.Text} using the public key." + "\n";
      txtOutput.Text = Encryption.Encrypt(publicKey, long.Parse(txtInput.Text));
    }

    private void btnDecrypt_Click(object sender, EventArgs e) {
      txtLog.Text += $"( + ) Decrypting {txtInput.Text} using the private key." + "\n";
      txtOutput.Text = Encryption.Decrypt(privateKey, long.Parse(txtInput.Text));
    }
  }
}
