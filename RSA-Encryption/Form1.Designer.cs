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
      this.txtP = new System.Windows.Forms.TextBox();
      this.numP1 = new System.Windows.Forms.NumericUpDown();
      this.numP2 = new System.Windows.Forms.NumericUpDown();
      this.lbl = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.gpbGenerate = new System.Windows.Forms.GroupBox();
      this.lblPrivatekey = new System.Windows.Forms.Label();
      this.lblPublickey = new System.Windows.Forms.Label();
      this.gpbLog = new System.Windows.Forms.GroupBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numP1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numP2)).BeginInit();
      this.gpbGenerate.SuspendLayout();
      this.gpbLog.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtP
      // 
      this.txtP.Location = new System.Drawing.Point(9, 49);
      this.txtP.Name = "txtP";
      this.txtP.Size = new System.Drawing.Size(280, 20);
      this.txtP.TabIndex = 0;
      // 
      // numP1
      // 
      this.numP1.Location = new System.Drawing.Point(114, 37);
      this.numP1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numP1.Name = "numP1";
      this.numP1.Size = new System.Drawing.Size(120, 20);
      this.numP1.TabIndex = 1;
      this.numP1.Value = new decimal(new int[] {
            137,
            0,
            0,
            0});
      this.numP1.ValueChanged += new System.EventHandler(this.calcMI);
      // 
      // numP2
      // 
      this.numP2.Location = new System.Drawing.Point(114, 63);
      this.numP2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numP2.Name = "numP2";
      this.numP2.Size = new System.Drawing.Size(120, 20);
      this.numP2.TabIndex = 2;
      this.numP2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.numP2.ValueChanged += new System.EventHandler(this.calcMI);
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.Location = new System.Drawing.Point(21, 39);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(87, 13);
      this.lbl.TabIndex = 3;
      this.lbl.Text = "Prime number #1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Prime number #2";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(24, 98);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(210, 23);
      this.btnGenerate.TabIndex = 5;
      this.btnGenerate.Text = "Generate RSA keypairs";
      this.btnGenerate.UseVisualStyleBackColor = true;
      // 
      // gpbGenerate
      // 
      this.gpbGenerate.Controls.Add(this.lblPublickey);
      this.gpbGenerate.Controls.Add(this.lblPrivatekey);
      this.gpbGenerate.Controls.Add(this.btnGenerate);
      this.gpbGenerate.Controls.Add(this.numP1);
      this.gpbGenerate.Controls.Add(this.label2);
      this.gpbGenerate.Controls.Add(this.numP2);
      this.gpbGenerate.Controls.Add(this.lbl);
      this.gpbGenerate.Location = new System.Drawing.Point(12, 12);
      this.gpbGenerate.Name = "gpbGenerate";
      this.gpbGenerate.Size = new System.Drawing.Size(256, 181);
      this.gpbGenerate.TabIndex = 6;
      this.gpbGenerate.TabStop = false;
      this.gpbGenerate.Text = "Generate";
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
      // lblPublickey
      // 
      this.lblPublickey.AutoSize = true;
      this.lblPublickey.Location = new System.Drawing.Point(21, 155);
      this.lblPublickey.Name = "lblPublickey";
      this.lblPublickey.Size = new System.Drawing.Size(59, 13);
      this.lblPublickey.TabIndex = 7;
      this.lblPublickey.Text = "Public key:";
      // 
      // gpbLog
      // 
      this.gpbLog.Controls.Add(this.richTextBox1);
      this.gpbLog.Location = new System.Drawing.Point(12, 199);
      this.gpbLog.Name = "gpbLog";
      this.gpbLog.Size = new System.Drawing.Size(570, 259);
      this.gpbLog.TabIndex = 7;
      this.gpbLog.TabStop = false;
      this.gpbLog.Text = "Log";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtP);
      this.groupBox1.Location = new System.Drawing.Point(274, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(308, 181);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Encrypt/Decrypt";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Input";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 98);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Output";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(9, 114);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(280, 20);
      this.textBox1.TabIndex = 10;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(113, 145);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(85, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "Encrypt";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(204, 145);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(85, 23);
      this.button2.TabIndex = 12;
      this.button2.Text = "Decrypt";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(8, 19);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(556, 234);
      this.richTextBox1.TabIndex = 13;
      this.richTextBox1.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(594, 470);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.gpbLog);
      this.Controls.Add(this.gpbGenerate);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numP1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numP2)).EndInit();
      this.gpbGenerate.ResumeLayout(false);
      this.gpbGenerate.PerformLayout();
      this.gpbLog.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtP;
    private System.Windows.Forms.NumericUpDown numP1;
    private System.Windows.Forms.NumericUpDown numP2;
    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnGenerate;
    private System.Windows.Forms.GroupBox gpbGenerate;
    private System.Windows.Forms.Label lblPublickey;
    private System.Windows.Forms.Label lblPrivatekey;
    private System.Windows.Forms.GroupBox gpbLog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

