namespace BitCoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bitcoinInput = new System.Windows.Forms.TextBox();
            this.bitcoinLabel = new System.Windows.Forms.Label();
            this.conversionButton = new System.Windows.Forms.Button();
            this.convertResult = new System.Windows.Forms.TextBox();
            this.convertResultLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableCurrencies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bitcoinInput
            // 
            this.bitcoinInput.Location = new System.Drawing.Point(362, 79);
            this.bitcoinInput.Name = "bitcoinInput";
            this.bitcoinInput.Size = new System.Drawing.Size(100, 20);
            this.bitcoinInput.TabIndex = 2;
            // 
            // bitcoinLabel
            // 
            this.bitcoinLabel.AutoSize = true;
            this.bitcoinLabel.BackColor = System.Drawing.Color.Transparent;
            this.bitcoinLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bitcoinLabel.Location = new System.Drawing.Point(359, 63);
            this.bitcoinLabel.Name = "bitcoinLabel";
            this.bitcoinLabel.Size = new System.Drawing.Size(145, 13);
            this.bitcoinLabel.TabIndex = 3;
            this.bitcoinLabel.Text = "Sisesta lähtesumma Bitcoinis:";
            this.bitcoinLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // conversionButton
            // 
            this.conversionButton.Location = new System.Drawing.Point(362, 173);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(75, 23);
            this.conversionButton.TabIndex = 1;
            this.conversionButton.Text = "Arvuta kurss";
            this.conversionButton.UseVisualStyleBackColor = true;
            this.conversionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // convertResult
            // 
            this.convertResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.convertResult.ForeColor = System.Drawing.Color.YellowGreen;
            this.convertResult.Location = new System.Drawing.Point(553, 119);
            this.convertResult.Name = "convertResult";
            this.convertResult.Size = new System.Drawing.Size(200, 38);
            this.convertResult.TabIndex = 4;
            this.convertResult.Text = "N/A";
            // 
            // convertResultLabel
            // 
            this.convertResultLabel.AutoSize = true;
            this.convertResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.convertResultLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.convertResultLabel.Location = new System.Drawing.Point(550, 103);
            this.convertResultLabel.Name = "convertResultLabel";
            this.convertResultLabel.Size = new System.Drawing.Size(50, 13);
            this.convertResultLabel.TabIndex = 5;
            this.convertResultLabel.Text = "Tulemus:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(362, 147);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(359, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sisesta soovitud valuuta lühend:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // availableCurrencies
            // 
            this.availableCurrencies.AutoSize = true;
            this.availableCurrencies.BackColor = System.Drawing.Color.Transparent;
            this.availableCurrencies.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.availableCurrencies.Location = new System.Drawing.Point(359, 131);
            this.availableCurrencies.Name = "availableCurrencies";
            this.availableCurrencies.Size = new System.Drawing.Size(139, 13);
            this.availableCurrencies.TabIndex = 8;
            this.availableCurrencies.Text = "EUR, USD, GBP, EEK, JPY";
            this.availableCurrencies.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 441);
            this.Controls.Add(this.availableCurrencies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.convertResultLabel);
            this.Controls.Add(this.convertResult);
            this.Controls.Add(this.bitcoinLabel);
            this.Controls.Add(this.bitcoinInput);
            this.Controls.Add(this.conversionButton);
            this.Name = "Form1";
            this.Text = "BitCoinCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bitcoinInput;
        private System.Windows.Forms.Label bitcoinLabel;
        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.TextBox convertResult;
        private System.Windows.Forms.Label convertResultLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label availableCurrencies;
    }
}

