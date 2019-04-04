namespace RSA_Encryption {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.txtInput = new System.Windows.Forms.TextBox();
      this.numPrime1 = new System.Windows.Forms.NumericUpDown();
      this.numPrime2 = new System.Windows.Forms.NumericUpDown();
      this.lblPrime1 = new System.Windows.Forms.Label();
      this.lblPrime2 = new System.Windows.Forms.Label();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.gpbGenerate = new System.Windows.Forms.GroupBox();
      this.txtPublicKey = new System.Windows.Forms.TextBox();
      this.lblPublickey = new System.Windows.Forms.Label();
      this.txtPrivateKey = new System.Windows.Forms.TextBox();
      this.lblPrivatekey = new System.Windows.Forms.Label();
      this.gpbLog = new System.Windows.Forms.GroupBox();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.gpbEncrypt = new System.Windows.Forms.GroupBox();
      this.btnDecrypt = new System.Windows.Forms.Button();
      this.btnEncrypt = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.lblOutput = new System.Windows.Forms.Label();
      this.lblInput = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numPrime1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPrime2)).BeginInit();
      this.gpbGenerate.SuspendLayout();
      this.gpbLog.SuspendLayout();
      this.gpbEncrypt.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(51, 66);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(233, 20);
      this.txtInput.TabIndex = 7;
      // 
      // numPrime1
      // 
      this.numPrime1.Location = new System.Drawing.Point(99, 37);
      this.numPrime1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.numPrime1.Name = "numPrime1";
      this.numPrime1.Size = new System.Drawing.Size(169, 20);
      this.numPrime1.TabIndex = 1;
      this.numPrime1.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numPrime1.ValueChanged += new System.EventHandler(this.numValueChanged);
      // 
      // numPrime2
      // 
      this.numPrime2.Location = new System.Drawing.Point(99, 68);
      this.numPrime2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.numPrime2.Name = "numPrime2";
      this.numPrime2.Size = new System.Drawing.Size(169, 20);
      this.numPrime2.TabIndex = 2;
      this.numPrime2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.numPrime2.ValueChanged += new System.EventHandler(this.numValueChanged);
      // 
      // lblPrime1
      // 
      this.lblPrime1.AutoSize = true;
      this.lblPrime1.Location = new System.Drawing.Point(5, 40);
      this.lblPrime1.Name = "lblPrime1";
      this.lblPrime1.Size = new System.Drawing.Size(87, 13);
      this.lblPrime1.TabIndex = 3;
      this.lblPrime1.Text = "Prime number #1";
      // 
      // lblPrime2
      // 
      this.lblPrime2.AutoSize = true;
      this.lblPrime2.Location = new System.Drawing.Point(6, 73);
      this.lblPrime2.Name = "lblPrime2";
      this.lblPrime2.Size = new System.Drawing.Size(87, 13);
      this.lblPrime2.TabIndex = 4;
      this.lblPrime2.Text = "Prime number #2";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(120, 98);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(148, 20);
      this.btnGenerate.TabIndex = 5;
      this.btnGenerate.Text = "Generate RSA keypairs";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerateClick);
      // 
      // gpbGenerate
      // 
      this.gpbGenerate.Controls.Add(this.txtPublicKey);
      this.gpbGenerate.Controls.Add(this.lblPublickey);
      this.gpbGenerate.Controls.Add(this.txtPrivateKey);
      this.gpbGenerate.Controls.Add(this.lblPrivatekey);
      this.gpbGenerate.Controls.Add(this.btnGenerate);
      this.gpbGenerate.Controls.Add(this.numPrime1);
      this.gpbGenerate.Controls.Add(this.lblPrime2);
      this.gpbGenerate.Controls.Add(this.numPrime2);
      this.gpbGenerate.Controls.Add(this.lblPrime1);
      this.gpbGenerate.Location = new System.Drawing.Point(12, 12);
      this.gpbGenerate.Name = "gpbGenerate";
      this.gpbGenerate.Size = new System.Drawing.Size(274, 210);
      this.gpbGenerate.TabIndex = 6;
      this.gpbGenerate.TabStop = false;
      this.gpbGenerate.Text = "Generate";
      // 
      // txtPublicKey
      // 
      this.txtPublicKey.Location = new System.Drawing.Point(78, 171);
      this.txtPublicKey.Name = "txtPublicKey";
      this.txtPublicKey.Size = new System.Drawing.Size(190, 20);
      this.txtPublicKey.TabIndex = 7;
      this.txtPublicKey.TextChanged += new System.EventHandler(this.txtKeyChanged);
      // 
      // lblPublickey
      // 
      this.lblPublickey.AutoSize = true;
      this.lblPublickey.Location = new System.Drawing.Point(6, 174);
      this.lblPublickey.Name = "lblPublickey";
      this.lblPublickey.Size = new System.Drawing.Size(59, 13);
      this.lblPublickey.TabIndex = 7;
      this.lblPublickey.Text = "Public key:";
      // 
      // txtPrivateKey
      // 
      this.txtPrivateKey.Location = new System.Drawing.Point(78, 141);
      this.txtPrivateKey.Name = "txtPrivateKey";
      this.txtPrivateKey.Size = new System.Drawing.Size(190, 20);
      this.txtPrivateKey.TabIndex = 6;
      this.txtPrivateKey.TextChanged += new System.EventHandler(this.txtKeyChanged);
      // 
      // lblPrivatekey
      // 
      this.lblPrivatekey.AutoSize = true;
      this.lblPrivatekey.Location = new System.Drawing.Point(6, 144);
      this.lblPrivatekey.Name = "lblPrivatekey";
      this.lblPrivatekey.Size = new System.Drawing.Size(66, 13);
      this.lblPrivatekey.TabIndex = 6;
      this.lblPrivatekey.Text = "Private key: ";
      // 
      // gpbLog
      // 
      this.gpbLog.Controls.Add(this.txtLog);
      this.gpbLog.Location = new System.Drawing.Point(12, 228);
      this.gpbLog.Name = "gpbLog";
      this.gpbLog.Size = new System.Drawing.Size(570, 230);
      this.gpbLog.TabIndex = 7;
      this.gpbLog.TabStop = false;
      this.gpbLog.Text = "Log";
      // 
      // txtLog
      // 
      this.txtLog.Location = new System.Drawing.Point(8, 19);
      this.txtLog.Name = "txtLog";
      this.txtLog.ReadOnly = true;
      this.txtLog.Size = new System.Drawing.Size(556, 205);
      this.txtLog.TabIndex = 20;
      this.txtLog.Text = "";
      // 
      // gpbEncrypt
      // 
      this.gpbEncrypt.Controls.Add(this.btnDecrypt);
      this.gpbEncrypt.Controls.Add(this.btnEncrypt);
      this.gpbEncrypt.Controls.Add(this.txtOutput);
      this.gpbEncrypt.Controls.Add(this.lblOutput);
      this.gpbEncrypt.Controls.Add(this.lblInput);
      this.gpbEncrypt.Controls.Add(this.txtInput);
      this.gpbEncrypt.Location = new System.Drawing.Point(292, 12);
      this.gpbEncrypt.Name = "gpbEncrypt";
      this.gpbEncrypt.Size = new System.Drawing.Size(290, 210);
      this.gpbEncrypt.TabIndex = 8;
      this.gpbEncrypt.TabStop = false;
      this.gpbEncrypt.Text = "Encrypt/Decrypt";
      // 
      // btnDecrypt
      // 
      this.btnDecrypt.Enabled = false;
      this.btnDecrypt.Location = new System.Drawing.Point(199, 169);
      this.btnDecrypt.Name = "btnDecrypt";
      this.btnDecrypt.Size = new System.Drawing.Size(85, 23);
      this.btnDecrypt.TabIndex = 12;
      this.btnDecrypt.Text = "Decrypt";
      this.btnDecrypt.UseVisualStyleBackColor = true;
      this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
      // 
      // btnEncrypt
      // 
      this.btnEncrypt.Enabled = false;
      this.btnEncrypt.Location = new System.Drawing.Point(108, 169);
      this.btnEncrypt.Name = "btnEncrypt";
      this.btnEncrypt.Size = new System.Drawing.Size(85, 23);
      this.btnEncrypt.TabIndex = 11;
      this.btnEncrypt.Text = "Encrypt";
      this.btnEncrypt.UseVisualStyleBackColor = true;
      this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(51, 99);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(233, 20);
      this.txtOutput.TabIndex = 10;
      // 
      // lblOutput
      // 
      this.lblOutput.AutoSize = true;
      this.lblOutput.Location = new System.Drawing.Point(6, 102);
      this.lblOutput.Name = "lblOutput";
      this.lblOutput.Size = new System.Drawing.Size(39, 13);
      this.lblOutput.TabIndex = 9;
      this.lblOutput.Text = "Output";
      // 
      // lblInput
      // 
      this.lblInput.AutoSize = true;
      this.lblInput.Location = new System.Drawing.Point(6, 69);
      this.lblInput.Name = "lblInput";
      this.lblInput.Size = new System.Drawing.Size(31, 13);
      this.lblInput.TabIndex = 8;
      this.lblInput.Text = "Input";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(594, 470);
      this.Controls.Add(this.gpbEncrypt);
      this.Controls.Add(this.gpbLog);
      this.Controls.Add(this.gpbGenerate);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.Text = "RSA Encryption";
      ((System.ComponentModel.ISupportInitialize)(this.numPrime1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPrime2)).EndInit();
      this.gpbGenerate.ResumeLayout(false);
      this.gpbGenerate.PerformLayout();
      this.gpbLog.ResumeLayout(false);
      this.gpbEncrypt.ResumeLayout(false);
      this.gpbEncrypt.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.NumericUpDown numPrime1;
    private System.Windows.Forms.NumericUpDown numPrime2;
    private System.Windows.Forms.Label lblPrime1;
    private System.Windows.Forms.Label lblPrime2;
    private System.Windows.Forms.Button btnGenerate;
    private System.Windows.Forms.GroupBox gpbGenerate;
    private System.Windows.Forms.Label lblPublickey;
    private System.Windows.Forms.Label lblPrivatekey;
    private System.Windows.Forms.GroupBox gpbLog;
    private System.Windows.Forms.GroupBox gpbEncrypt;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Label lblOutput;
    private System.Windows.Forms.Label lblInput;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
    }
}

