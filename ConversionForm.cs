namespace CurrencyConverter
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void ConvertCurrency(object sender, EventArgs e)
        {


            if (currencySelect.SelectedIndex == 0)
            {
                const decimal ConversionCoefficient = 1.95583m;

                decimal amountBGN = this.numericUpDownAmount.Value;
                decimal amountEUR = amountBGN / ConversionCoefficient;

                if (amountBGN == 0)
                {
                    this.resultLabel.Text = "Invalid number";
                }
                else
                {
                    this.resultLabel.Text = $"{amountBGN} BGN = {amountEUR:F2} EUR";
                }
                

            }
            else if (currencySelect.SelectedIndex == 1)
            {
                const decimal ConversionCoefficient = 1.95583m;

                decimal amountEUR = this.numericUpDownAmount.Value;
                decimal amountBGN = amountEUR * ConversionCoefficient;

                if(amountEUR <= 0)
                {
                    this.resultLabel.Text = "Invalid number";
                }
                else
                {
                    this.resultLabel.Text = $"{amountEUR} EUR = {amountBGN:F2} BGN";
                }
            }
            else
            {
                this.resultLabel.Text = "Select a currency!";
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConversionForm_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void currencySelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}