namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPrimeNumbers = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lstPrimeNumbers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrimeNumbers
            // 
            this.BtnPrimeNumbers.Location = new System.Drawing.Point(43, 24);
            this.BtnPrimeNumbers.Name = "BtnPrimeNumbers";
            this.BtnPrimeNumbers.Size = new System.Drawing.Size(137, 23);
            this.BtnPrimeNumbers.TabIndex = 0;
            this.BtnPrimeNumbers.Text = "Generate Primes";
            this.BtnPrimeNumbers.UseVisualStyleBackColor = true;
            this.BtnPrimeNumbers.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(208, 24);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(139, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lstPrimeNumbers
            // 
            this.lstPrimeNumbers.FormattingEnabled = true;
            this.lstPrimeNumbers.Location = new System.Drawing.Point(43, 83);
            this.lstPrimeNumbers.Name = "lstPrimeNumbers";
            this.lstPrimeNumbers.Size = new System.Drawing.Size(171, 316);
            this.lstPrimeNumbers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert First Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert Last Number Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(220, 83);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearListBox.TabIndex = 7;
            this.btnClearListBox.Text = "Clear";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPrimeNumbers);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPrimeNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrimeNumbers;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox lstPrimeNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearListBox;
    }
}

