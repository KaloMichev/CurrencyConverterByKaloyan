namespace CurrencyConverter
{
    partial class ConversionForm
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
            numericUpDownAmount = new NumericUpDown();
            resultLabel = new Label();
            resultButton = new Button();
            currencySelect = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Location = new Point(52, 50);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(120, 23);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.PaleGreen;
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultLabel.Location = new Point(29, 90);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(354, 23);
            resultLabel.TabIndex = 2;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            resultLabel.Click += resultLabel_Click;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(305, 50);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(75, 23);
            resultButton.TabIndex = 3;
            resultButton.Text = "Convert";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += ConvertCurrency;
            // 
            // currencySelect
            // 
            currencySelect.FormattingEnabled = true;
            currencySelect.Items.AddRange(new object[] { "BGN to EUR", "EUR to BGN" });
            currencySelect.Location = new Point(178, 50);
            currencySelect.Name = "currencySelect";
            currencySelect.Size = new Size(121, 23);
            currencySelect.TabIndex = 4;
            currencySelect.Text = "Select currency...";
            currencySelect.SelectedIndexChanged += currencySelect_SelectedIndexChanged;
            // 
            // ConversionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 172);
            Controls.Add(currencySelect);
            Controls.Add(resultButton);
            Controls.Add(resultLabel);
            Controls.Add(numericUpDownAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConversionForm";
            Text = "CurrencyConverterByKaloyan";
            Load += ConversionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private Label resultLabel;
        private Button resultButton;
        private ComboBox currencySelect;
    }
}