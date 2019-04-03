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
      this.lblPublickey = new System.Windows.Forms.Label();
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
      this.txtInput.Location = new System.Drawing.Point(9, 51);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(275, 20);
      this.txtInput.TabIndex = 0;
      // 
      // numPrime1
      // 
      this.numPrime1.Location = new System.Drawing.Point(114, 37);
      this.numPrime1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numPrime1.Name = "numPrime1";
      this.numPrime1.Size = new System.Drawing.Size(154, 20);
      this.numPrime1.TabIndex = 1;
      this.numPrime1.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
      this.numPrime1.ValueChanged += new System.EventHandler(this.numValueChanged);
      // 
      // numPrime2
      // 
      this.numPrime2.Location = new System.Drawing.Point(114, 63);
      this.numPrime2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numPrime2.Name = "numPrime2";
      this.numPrime2.Size = new System.Drawing.Size(154, 20);
      this.numPrime2.TabIndex = 2;
      this.numPrime2.ValueChanged += new System.EventHandler(this.numValueChanged);
      // 
      // lblPrime1
      // 
      this.lblPrime1.AutoSize = true;
      this.lblPrime1.Location = new System.Drawing.Point(21, 39);
      this.lblPrime1.Name = "lblPrime1";
      this.lblPrime1.Size = new System.Drawing.Size(87, 13);
      this.lblPrime1.TabIndex = 3;
      this.lblPrime1.Text = "Prime number #1";
      // 
      // lblPrime2
      // 
      this.lblPrime2.AutoSize = true;
      this.lblPrime2.Location = new System.Drawing.Point(21, 65);
      this.lblPrime2.Name = "lblPrime2";
      this.lblPrime2.Size = new System.Drawing.Size(87, 13);
      this.lblPrime2.TabIndex = 4;
      this.lblPrime2.Text = "Prime number #2";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(114, 92);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(154, 23);
      this.btnGenerate.TabIndex = 5;
      this.btnGenerate.Text = "Generate RSA keypairs";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      // 
      // gpbGenerate
      // 
      this.gpbGenerate.Controls.Add(this.lblPublickey);
      this.gpbGenerate.Controls.Add(this.lblPrivatekey);
      this.gpbGenerate.Controls.Add(this.btnGenerate);
      this.gpbGenerate.Controls.Add(this.numPrime1);
      this.gpbGenerate.Controls.Add(this.lblPrime2);
      this.gpbGenerate.Controls.Add(this.numPrime2);
      this.gpbGenerate.Controls.Add(this.lblPrime1);
      this.gpbGenerate.Location = new System.Drawing.Point(12, 12);
      this.gpbGenerate.Name = "gpbGenerate";
      this.gpbGenerate.Size = new System.Drawing.Size(274, 181);
      this.gpbGenerate.TabIndex = 6;
      this.gpbGenerate.TabStop = false;
      this.gpbGenerate.Text = "Generate";
      // 
      // lblPublickey
      // 
      this.lblPublickey.AutoSize = true;
      this.lblPublickey.Location = new System.Drawing.Point(21, 155);
      this.lblPublickey.Name = "lblPublickey";
      this.lblPublickey.Size = new System.Drawing.Size(59, 13);
      this.lblPublickey.TabIndex = 7;
      this.lblPublickey.Text = "Public key:";
      // 
      // lblPrivatekey
      // 
      this.lblPrivatekey.AutoSize = true;
      this.lblPrivatekey.Location = new System.Drawing.Point(21, 133);
      this.lblPrivatekey.Name = "lblPrivatekey";
      this.lblPrivatekey.Size = new System.Drawing.Size(66, 13);
      this.lblPrivatekey.TabIndex = 6;
      this.lblPrivatekey.Text = "Private key: ";
      // 
      // gpbLog
      // 
      this.gpbLog.Controls.Add(this.txtLog);
      this.gpbLog.Location = new System.Drawing.Point(12, 199);
      this.gpbLog.Name = "gpbLog";
      this.gpbLog.Size = new System.Drawing.Size(570, 259);
      this.gpbLog.TabIndex = 7;
      this.gpbLog.TabStop = false;
      this.gpbLog.Text = "Log";
      // 
      // txtLog
      // 
      this.txtLog.Location = new System.Drawing.Point(8, 19);
      this.txtLog.Name = "txtLog";
      this.txtLog.ReadOnly = true;
      this.txtLog.Size = new System.Drawing.Size(556, 234);
      this.txtLog.TabIndex = 13;
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
      this.gpbEncrypt.Size = new System.Drawing.Size(290, 181);
      this.gpbEncrypt.TabIndex = 8;
      this.gpbEncrypt.TabStop = false;
      this.gpbEncrypt.Text = "Encrypt/Decrypt";
      // 
      // btnDecrypt
      // 
      this.btnDecrypt.Enabled = false;
      this.btnDecrypt.Location = new System.Drawing.Point(199, 145);
      this.btnDecrypt.Name = "btnDecrypt";
      this.btnDecrypt.Size = new System.Drawing.Size(85, 23);
      this.btnDecrypt.TabIndex = 12;
      this.btnDecrypt.Text = "Decrypt";
      this.btnDecrypt.UseVisualStyleBackColor = true;
      // 
      // btnEncrypt
      // 
      this.btnEncrypt.Enabled = false;
      this.btnEncrypt.Location = new System.Drawing.Point(108, 145);
      this.btnEncrypt.Name = "btnEncrypt";
      this.btnEncrypt.Size = new System.Drawing.Size(85, 23);
      this.btnEncrypt.TabIndex = 11;
      this.btnEncrypt.Text = "Encrypt";
      this.btnEncrypt.UseVisualStyleBackColor = true;
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(9, 108);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(275, 20);
      this.txtOutput.TabIndex = 10;
      // 
      // lblOutput
      // 
      this.lblOutput.AutoSize = true;
      this.lblOutput.Location = new System.Drawing.Point(6, 92);
      this.lblOutput.Name = "lblOutput";
      this.lblOutput.Size = new System.Drawing.Size(39, 13);
      this.lblOutput.TabIndex = 9;
      this.lblOutput.Text = "Output";
      // 
      // lblInput
      // 
      this.lblInput.AutoSize = true;
      this.lblInput.Location = new System.Drawing.Point(6, 35);
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
      this.Name = "Form1";
      this.Text = "Form1";
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
  }
}

