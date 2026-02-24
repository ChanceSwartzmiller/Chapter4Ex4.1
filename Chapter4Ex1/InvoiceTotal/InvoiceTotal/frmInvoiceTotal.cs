namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Decimal.Parse(txtSubtotal.Text);
            decimal discountPct = .25m;

            decimal discountAmt = Decimal.Round(subtotal * discountPct, 2);
            decimal invoiceTotal = Decimal.Round(subtotal - discountAmt, 2);

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString();
            txtTotal.Text = invoiceTotal.ToString();

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}