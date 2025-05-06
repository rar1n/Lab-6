namespace Lab062
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "�� ������� �����!";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = x1 + x2;
            tbY.Text = y.ToString("0.0000");
            double seredne = (x1 + x2) / 2;
            tbSeredne.Text = seredne.ToString("0.0000");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbSeredne.Text = string.Empty;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
