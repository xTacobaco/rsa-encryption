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
      ((System.ComponentModel.ISupportInitialize)(this.numP1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numP2)).BeginInit();
      this.SuspendLayout();
      // 
      // txtP
      // 
      this.txtP.Location = new System.Drawing.Point(155, 155);
      this.txtP.Name = "txtP";
      this.txtP.Size = new System.Drawing.Size(232, 20);
      this.txtP.TabIndex = 0;
      // 
      // numP1
      // 
      this.numP1.Location = new System.Drawing.Point(155, 45);
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
      // 
      // numP2
      // 
      this.numP2.Location = new System.Drawing.Point(155, 71);
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
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.Location = new System.Drawing.Point(62, 47);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(87, 13);
      this.lbl.TabIndex = 3;
      this.lbl.Text = "Prime number #1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(62, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Prime number #2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(594, 470);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbl);
      this.Controls.Add(this.numP2);
      this.Controls.Add(this.numP1);
      this.Controls.Add(this.txtP);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numP1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numP2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtP;
    private System.Windows.Forms.NumericUpDown numP1;
    private System.Windows.Forms.NumericUpDown numP2;
    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.Label label2;
  }
}

