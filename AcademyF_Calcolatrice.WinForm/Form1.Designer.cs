namespace AcademyF_Calcolatrice.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValue = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnVirgola = new System.Windows.Forms.Button();
            this.btnUguale = new System.Windows.Forms.Button();
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnSottrai = new System.Windows.Forms.Button();
            this.btnMoltiplica = new System.Windows.Forms.Button();
            this.btnDividi = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(47, 49);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(61, 25);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Valore";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(41, 108);
            this.textValue.Name = "textValue";
            this.textValue.ReadOnly = true;
            this.textValue.Size = new System.Drawing.Size(247, 31);
            this.textValue.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(41, 373);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 62);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(141, 373);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 62);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(241, 373);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 62);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(41, 278);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 62);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(141, 278);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 62);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(141, 466);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 62);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(241, 278);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 62);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(41, 185);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 62);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(141, 185);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 62);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(241, 185);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 62);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnVirgola
            // 
            this.btnVirgola.Location = new System.Drawing.Point(41, 466);
            this.btnVirgola.Name = "btnVirgola";
            this.btnVirgola.Size = new System.Drawing.Size(62, 62);
            this.btnVirgola.TabIndex = 12;
            this.btnVirgola.Text = ",";
            this.btnVirgola.UseVisualStyleBackColor = true;
            this.btnVirgola.Click += new System.EventHandler(this.btnVirgola_Click);
            // 
            // btnUguale
            // 
            this.btnUguale.Location = new System.Drawing.Point(241, 466);
            this.btnUguale.Name = "btnUguale";
            this.btnUguale.Size = new System.Drawing.Size(62, 62);
            this.btnUguale.TabIndex = 13;
            this.btnUguale.Text = "=";
            this.btnUguale.UseVisualStyleBackColor = true;
            this.btnUguale.Click += new System.EventHandler(this.btnUguale_Click);
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(357, 185);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(62, 62);
            this.btnSomma.TabIndex = 14;
            this.btnSomma.Tag = "somma";
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnSottrai
            // 
            this.btnSottrai.Location = new System.Drawing.Point(357, 278);
            this.btnSottrai.Name = "btnSottrai";
            this.btnSottrai.Size = new System.Drawing.Size(62, 62);
            this.btnSottrai.TabIndex = 15;
            this.btnSottrai.Tag = "sottrai";
            this.btnSottrai.Text = "-";
            this.btnSottrai.UseVisualStyleBackColor = true;
            this.btnSottrai.Click += new System.EventHandler(this.btnSottrai_Click);
            // 
            // btnMoltiplica
            // 
            this.btnMoltiplica.Location = new System.Drawing.Point(357, 373);
            this.btnMoltiplica.Name = "btnMoltiplica";
            this.btnMoltiplica.Size = new System.Drawing.Size(62, 62);
            this.btnMoltiplica.TabIndex = 16;
            this.btnMoltiplica.Tag = "moltiplica";
            this.btnMoltiplica.Text = "*";
            this.btnMoltiplica.UseVisualStyleBackColor = true;
            this.btnMoltiplica.Click += new System.EventHandler(this.btnMoltiplica_Click);
            // 
            // btnDividi
            // 
            this.btnDividi.Location = new System.Drawing.Point(357, 466);
            this.btnDividi.Name = "btnDividi";
            this.btnDividi.Size = new System.Drawing.Size(62, 62);
            this.btnDividi.TabIndex = 17;
            this.btnDividi.Tag = "dividi";
            this.btnDividi.Text = "/";
            this.btnDividi.UseVisualStyleBackColor = true;
            this.btnDividi.Click += new System.EventHandler(this.btnDividi_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 62);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 540);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDividi);
            this.Controls.Add(this.btnMoltiplica);
            this.Controls.Add(this.btnSottrai);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.btnUguale);
            this.Controls.Add(this.btnVirgola);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.lblValue);
            this.Name = "Form1";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValue;
        private TextBox textValue;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnVirgola;
        private Button btnUguale;
        private Button btnSomma;
        private Button btnSottrai;
        private Button btnMoltiplica;
        private Button btnDividi;
        private Button btnCancel;
    }
}