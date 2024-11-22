﻿namespace BitCoinCalculator
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
            this.currencySelector = new System.Windows.Forms.ComboBox();
            this.bitcoinInput = new System.Windows.Forms.TextBox();
            this.bitcoinLabel = new System.Windows.Forms.Label();
            this.conversionButton = new System.Windows.Forms.Button();
            this.convertResult = new System.Windows.Forms.TextBox();
            this.convertResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencySelector
            // 
            this.currencySelector.FormattingEnabled = true;
            this.currencySelector.Items.AddRange(new object[] { "EUR", "USD", "GBP", "EEK" });
            this.currencySelector.Location = new System.Drawing.Point(362, 118);
            this.currencySelector.Name = "currencySelector";
            this.currencySelector.Size = new System.Drawing.Size(121, 21);
            this.currencySelector.TabIndex = 0;
            this.currencySelector.Text = "Vali sihtvaluuta:";
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
            this.conversionButton.Location = new System.Drawing.Point(362, 158);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 441);
            this.Controls.Add(this.convertResultLabel);
            this.Controls.Add(this.convertResult);
            this.Controls.Add(this.bitcoinLabel);
            this.Controls.Add(this.bitcoinInput);
            this.Controls.Add(this.conversionButton);
            this.Controls.Add(this.currencySelector);
            this.Name = "Form1";
            this.Text = "BitCoinCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox currencySelector;
        private System.Windows.Forms.TextBox bitcoinInput;
        private System.Windows.Forms.Label bitcoinLabel;
        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.TextBox convertResult;
        private System.Windows.Forms.Label convertResultLabel;
    }
}

