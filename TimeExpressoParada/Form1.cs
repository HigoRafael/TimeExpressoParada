namespace TimeExpressoParada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void CalcularTimer(String horIniti, String horFinal)
        {
            try
            {
                TimeSpan intervalo = Convert.ToDateTime(horFinal).AddDays(1) - Convert.ToDateTime(horIniti);
                MessageBox.Show("Hora (s): " + intervalo.Hours.ToString() + " e " + intervalo.Minutes.ToString() + " minutos.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique o formato dos dados inseridos" + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(mtxtIniTimer.Text) && e.KeyCode == Keys.Down)
            {
                mtxtFinalTimer.Focus();
            }
        }

        private void mtxtFinalTimer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(mtxtFinalTimer.Text))
                {
                    btnCalc_Click(this, null);
                    mtxtIniTimer.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);
            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularTimer(mtxtIniTimer.Text, mtxtFinalTimer.Text);
                mtxtIniTimer.Text = "";
                mtxtFinalTimer.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);
            }
        }
    }
}